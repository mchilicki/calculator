using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    public abstract class BaseOperation
    {
        protected Number _firstNumber;
        protected Number _secondNumber;
        
        public abstract Number Execute();
        public abstract string OperationSign { get; }

        public static BaseOperation EmptyOperation { get; } 
            = new NullOperation(Number.EmptyNumber, Number.EmptyNumber);

        public BaseOperation(Number firstNumber, Number secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
    }
}
