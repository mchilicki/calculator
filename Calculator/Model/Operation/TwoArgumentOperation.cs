using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class TwoArgumentOperation : Operation
    {
        protected Number _firstNumber;
        protected Number _secondNumber;

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
