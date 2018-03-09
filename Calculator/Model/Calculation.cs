using Calculator.Enum;
using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;


namespace Calculator.Model
{
    public class Calculation
    {
        public BaseOperation Operation { get; set; }

        private Number _firstNumber;
        public Number FirstNumber
        {
            get
            {
                // TODO switch it to NullNumber later
                if (_firstNumber == null)
                    _firstNumber = new Number(0);
                return _firstNumber;
            }
            set
            {
                _firstNumber = new Number(value.Value);
               // TODO RaisePropertyChanged(nameof(FirstNumber));
            }
        }

        private Number _secondNumber;
        public Number SecondNumber
        {
            get
            {
                // TODO switch it to null number
                if (_firstNumber == null)
                    _firstNumber = new Number(0);
                return _secondNumber;
            }
            set
            {
                _secondNumber = new Number(value.Value);
                // TODO RaisePropertyChanged(nameof(SecondNumber));
            }
        }
        public OperationType OperationType { get; set; }
    }
}
