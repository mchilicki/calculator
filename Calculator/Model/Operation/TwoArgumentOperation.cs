using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class TwoArgumentOperation : BaseOperation
    {
        public Number _firstNumber;
        public Number _secondNumber;

        public TwoArgumentOperation(Number firstNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = Number.EmptyNumber;
        }

        public TwoArgumentOperation(Number firstNumber, Number secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
    }
}
