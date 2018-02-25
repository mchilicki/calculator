using Calculator.Enum;
using Calculator.Model.Operation.Base;
using Calculator.Model.State;

namespace Calculator.Model.Entity
{
    public class Calculation
    {
        public CalculationState CalculationState = new InsertFirstNumberState();

        public BaseOperation Operation { get; set; }

        public FastOperation FastOperation { get; set; }

        private Number _firstNumber;
        public Number FirstNumber
        {
            get
            {
                // switch it to NullNumber later
                if (_firstNumber == null)
                    _firstNumber = new Number(0);
                return _firstNumber;
            }
            set
            {
                _firstNumber = new Number(value.Value);
               // RaisePropertyChanged(nameof(FirstNumber));
            }
        }

        private Number _secondNumber;
        public Number SecondNumber
        {
            get
            {
                // switch it to null number
                if (_firstNumber == null)
                    _firstNumber = new Number(0);
                return _secondNumber;
            }
            set
            {
                _secondNumber = new Number(value.Value);
                // RaisePropertyChanged(nameof(SecondNumber));
            }
        }

        private OperationType _operationType;
        public OperationType OperationType
        {
            get
            {
                return _operationType;
            }
            set
            {
                _operationType = value;
                // RaisePropertyChanged(nameof(OperationType));
            }
        }
    }
}
