using Calculator.Model;
using Calculator.ViewModel.Base;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    class CalculatorViewModel : BaseViewModel
    {
        private string _firstNumber = string.Empty;
        public string FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
                //RaisePropertyChanged(nameof(Calculations));
            }
        }

        private string _secondNumber = string.Empty;
        public string SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
                //RaisePropertyChanged(nameof(Calculations));
            }
        }

        /*TODO Normalize this method
         * private string _calculations = string.Empty;
        public string Calculations
        {
            get
            {
                return _firstNumber + " " 
                    + _calculationManager.OperationSign + 
                    " " + _secondNumber;
            }
            set
            {
                _calculations = value;
                RaisePropertyChanged(nameof(Calculations));
            }
        }*/

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
                            FirstNumber += number.ToString();
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
                        operationSign =>
                        {
                            
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
                            FirstNumber = string.Empty;
                            SecondNumber = string.Empty;
                            Result = string.Empty;
                        });
                }
                return _clearCommand;
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

                        });
                }
                return _dotCommand;
            }
        }
    }
}
