using Calculator.Enum;
using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using Calculator.ViewModel.Base;
using System.Windows;
using System.Windows.Input;
using Calculator.Properties;
using System;

namespace Calculator.ViewModel
{
    class CalculatorViewModel : BaseViewModel
    {
        private BaseOperation _operation;

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
                switch (CheckOperationClass())
                {
                    case OperationSignClass.Undefined:
                    case OperationSignClass.WithoutSign:
                    default:
                        return _firstNumber;
                    case OperationSignClass.Normal:
                        return _firstNumber + " " + OperationType.GetSign()
                            + " " + _secondNumber;
                    case OperationSignClass.AfterNumber:
                        return _firstNumber + OperationType.GetSign();
                    case OperationSignClass.BeforeNumber:
                        return OperationType.GetSign() + _firstNumber;
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
                            if (ShouldFirstNumberBeEntered())
                                FirstNumber += number.ToString();
                            else
                                SecondNumber += number.ToString();
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
                            FormatNumbers();
                            OperationType = (OperationType)operationType;
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
                            FormatNumbers();
                            OperationType = (OperationType)operationType;
                            SecondNumber = string.Empty;
                            _operation = OperationFactory.Create(
                                new Number(_firstNumber),
                                new Number(_secondNumber),
                                OperationType);
                            try
                            { 
                                Number result = _operation.Execute();
                                Result = result.ToString();
                            }
                                catch (ArithmeticException ex)
                            {
                                Result = ex.Message;
                            }                            
                            ClearAfterExecution();
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
                            FormatNumbers();
                            _operation = OperationFactory.Create(
                                new Number(_firstNumber),
                                new Number(_secondNumber),
                                OperationType);
                            try
                            {
                                Number result = _operation.Execute();
                                Result = result.ToString();
                            }
                            catch (ArithmeticException ex)
                            {
                                Result = ex.Message;
                            }                            
                            ClearAfterExecution();
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
                        });
                }
                return _dotCommand;
            }
        }

        #endregion Commands

        private bool ShouldFirstNumberBeEntered()
        {
            return !(OperationType != OperationType.Undefined);
        }

        private void ClearAll()
        {
            FirstNumber = string.Empty;
            SecondNumber = string.Empty;
            Result = string.Empty;
            OperationType = OperationType.Undefined;
            _operation = null;
        }

        private void ClearAfterExecution()
        {
            //FirstNumber = Result;
            _operation = null;
        }

        private OperationSignClass CheckOperationClass()
        {
            switch (_operationType)
            {
                case OperationType.Addition:
                case OperationType.Division:
                case OperationType.Multiplication:
                case OperationType.Substraction:
                    return OperationSignClass.Normal;
                case OperationType.SquareExponent:
                    return OperationSignClass.AfterNumber;
                case OperationType.SquareRoot:
                    return OperationSignClass.BeforeNumber;
                case OperationType.ChangingSign:
                    return OperationSignClass.WithoutSign;
                default:
                    return OperationSignClass.Undefined;
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
    }
}

