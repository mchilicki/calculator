using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    public class NullOperation : BaseOperation
    {
        public NullOperation(Number firstNumber, Number secondNumber) 
            : base(Number.EmptyNumber, Number.EmptyNumber) 
        {
        }

        public override string OperationSign { get; } = string.Empty;

        public override Number Execute()
        {
            return Number.EmptyNumber;
        }
    }
}