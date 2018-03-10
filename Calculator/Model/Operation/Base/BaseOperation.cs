using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    public abstract class BaseOperation
    {
        protected Number _firstNumber;
        protected Number _secondNumber;
        
        public abstract Number Execute();

        public BaseOperation(Number firstNumber, Number secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
    }
}
