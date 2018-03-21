using Calculator.Enum;
using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using Calculator.ViewModel.Base;
using System.Windows.Input;
using Calculator.Properties;
using System;
using Calculator.Helper;

namespace Calculator.ViewModel
{
    class CalculatorViewModel : BaseViewModel
    {
        #region Properties and fields

        private BaseOperation _operation;

        private OperationState _operationState = OperationState.Normal;

        private string _firstNumber = string.Empty;
        private string FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
                RaisePropertyChanged(nameof(Calculations));
            }
        }

        private string _secondNumber = string.Empty;
        private string SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
                RaisePropertyChanged(nameof(Calculations));
            }
        }

        private OperationType _operationType = OperationType.Undefined;
        private OperationType OperationType
        {
            get
            {
                return _operationType;
            }
            set
            {
                _operationType = value;
                RaisePropertyChanged(nameof(Calculations));
            }
        }

        private string _calculations = string.Empty;
        public string Calculations
        {
            get
            {
                switch (CheckOperationType())
                {
                    case OperationSignType.Undefined:
                    case OperationSignType.WithoutSign:
                    default:
                        return $"{_firstNumber}";
                    case OperationSignType.Normal:
                        return $"{_firstNumber} {OperationType.GetSign()} {_secondNumber}";
                    case OperationSignType.AfterNumber:
                        return $"{_firstNumber}{OperationType.GetSign()}";
                    case OperationSignType.BeforeNumber:
                        return $"{OperationType.GetSign()}{_firstNumber}";
                }
            }
            set
            {
                _calculations = value;
                RaisePropertyChanged(nameof(Calculations));
            }
        }

        private string _result;
        public string Result
        {
            get
            {
                if (_result == null)
                    _result = string.Empty;
                return _result;
            }
            set
            {
                _result = value;
                RaisePropertyChanged(nameof(Result));
            }
        }

        #endregion Properties and fields

        #region Methods

        private void Execute()
        {            
            ClearBeforeExecution();
            FormatNumbers();
            _operation = OperationFactory.Create(OperationType);
            try
            {
                Result = _operation.Execute().
					ToString();
            }
            catch (ArithmeticException ex)
            {
                Result = ex.Message;
                _operationState = OperationState.Blocked;
            }
            ClearAfterExecution();
        }

        #region Operation State and Format

        private bool ShouldFirstNumberBeEntered()
        {
            return !(OperationType != OperationType.Undefined);
        }       

        private OperationSignType CheckOperationType()
        {
            switch (_operationType)
            {
                case OperationType.Addition:
                case OperationType.Division:
                case OperationType.Multiplication:
                case OperationType.Substraction:
                    return OperationSignType.Normal;
                case OperationType.SquareExponent:
                    return OperationSignType.AfterNumber;
                case OperationType.SquareRoot:
                case OperationType.ChangingSign:
                    return OperationSignType.BeforeNumber;
                default:
                    return OperationSignType.Undefined;
            }
        }

        private void FormatNumbers()
        {
            if (FirstNumber != null)
            {
                if (FirstNumber == Resources.Dot || FirstNumber == string.Empty || FirstNumber == null)
                    FirstNumber = Resources.Number0;
                if (FirstNumber.EndsWith(Resources.Dot))
                    FirstNumber = FirstNumber.Remove(FirstNumber.Length - 1);
                if (FirstNumber.StartsWith(Resources.Dot))
                    FirstNumber = Resources.Number0 + FirstNumber;
            }
            if (SecondNumber != null)
            {
                if (SecondNumber == Resources.Dot)
                    SecondNumber = Resources.Number0;
                if (SecondNumber.EndsWith(Resources.Dot))
                    SecondNumber = SecondNumber.Remove(SecondNumber.Length - 1);
                if (SecondNumber.StartsWith(Resources.Dot))
                    SecondNumber = Resources.Number0 + SecondNumber;
            }
        }

        #endregion Operation State and Format

        #region Clearing

        private void ClearAll()
        {
            FirstNumber = string.Empty;
            SecondNumber = string.Empty;
            Result = string.Empty;
            OperationType = OperationType.Undefined;
            _operationState = OperationState.Normal;
            _operation = null;
        }

        private void ClearAfterExecution()
        {
            if (_operationState != OperationState.Blocked)
                _operationState = OperationState.JustPerformedExecution;
            _operation = null;
        }

        private void ClearBeforeExecution()
        {
            if (_operationState == OperationState.JustPerformedExecution)
            {
                FirstNumber = Result;
                Result = string.Empty;
                _operationState = OperationState.Normal;
            }
        }

        private void ClearAllBeforeExecution()
        {
            if (_operationState == OperationState.JustPerformedExecution)
            {
                ClearAll();
                _operationState = OperationState.Normal;
            }
        }

        private void ClearBeforeOperation()
        {
            if (_operationState == OperationState.JustPerformedExecution)
            {
                FirstNumber = Result;
                SecondNumber = string.Empty;
                OperationType = OperationType.Undefined;
                _operationState = OperationState.Normal;
            }
        }

        #endregion Clearing

        #endregion Methods

        #region Commands

        private ICommand _numericCommand;
        public ICommand NumericCommand
        {
            get
            {
                if (_numericCommand == null)
                {
                    _numericCommand = new RelayCommand(
                        number =>
                        {
                            ClearAllBeforeExecution();
                            if (ShouldFirstNumberBeEntered())
                                FirstNumber += number.ToString();
                            else
                                SecondNumber += number.ToString();
                        },
                        operationType =>
                        {
                            return (_operationState != OperationState.Blocked);
                        });
                }
                return _numericCommand;
            }
        }

        private ICommand _operationCommand;
        public ICommand OperationCommand
        {
            get
            {
                if (_operationCommand == null)
                {
                    _operationCommand = new RelayCommand(
                        operationType =>
                        {
                            ClearBeforeOperation();
                            FormatNumbers();
                            OperationType = (OperationType)operationType;
                        },
                        operationType =>
                        {
                            return (_operationState != OperationState.Blocked);
                        });
                }
                return _operationCommand;
            }
        }

        private ICommand _clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null)
                {
                    _clearCommand = new NoParameterCommand(
                        () =>
                        {
                            ClearAll();
                        });
                }
                return _clearCommand;
            }
        }

        private ICommand _fastOperationCommand;
        public ICommand FastOperationCommand
        {
            get
            {
                if (_fastOperationCommand == null)
                {
                    _fastOperationCommand = new RelayCommand(
                        operationType =>
                        {
                            OperationType = (OperationType)operationType;
                            SecondNumber = string.Empty;
                            Execute();
                        },
                        operationType =>
                        {
                            return (_operationState != OperationState.Blocked);
                        });
                }
                return _fastOperationCommand;
            }
        }

        private ICommand _executeCommand;
        public ICommand ExecuteCommand
        {
            get
            {
                if (_executeCommand == null)
                {
                    _executeCommand = new NoParameterCommand(
                        () =>
                        {
                            Execute();
                        },
                        () =>
                        {
                            return (_operationState != OperationState.Blocked);
                        });
                }
                return _executeCommand;
            }
        }

        private ICommand _dotCommand;
        public ICommand DotCommand
        {
            get
            {
                if (_dotCommand == null)
                {
                    _dotCommand = new NoParameterCommand(
                        () =>
                        {
                            ClearAllBeforeExecution();
                            if (ShouldFirstNumberBeEntered())
                            {
                                if (!FirstNumber.Contains(Resources.Dot))
                                    FirstNumber += Resources.Dot;
                            }
                            else
                            {
                                if (!SecondNumber.Contains(Resources.Dot))
                                    SecondNumber += Resources.Dot;
                            }
                        },
                        () =>
                        {
                            return (_operationState != OperationState.Blocked);
                        });
                }
                return _dotCommand;
            }
        }

        #endregion Commands
    }
}

