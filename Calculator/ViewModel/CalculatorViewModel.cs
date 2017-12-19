using Calculator.Model;
using Calculator.ViewModel.Base;
using System.Windows;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    class CalculatorViewModel : BaseViewModel
    {
        private CalculationManager _calculationManager = new CalculationManager();

        private ICommand _numericCommand;    
        public ICommand NumericCommand
        {
            get
            {
                if (_numericCommand == null)
                {
                    _numericCommand = new RelayCommand(
                        number => ShowNumber(number));
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
                        operationSign => ShowNumber(operationSign));
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
                        () => ShowNumber("clearing completed"));
                }
                return _clearCommand;
            }
        }

        private void ShowNumber(object number)
        {
            MessageBox.Show(number.ToString());
        }
    }
}
