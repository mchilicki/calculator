using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public class NullOperation : BaseOperation
    {
        public override string OperationSign { get; } = string.Empty;

        public override Number Execute()
        {
            return Number.EmptyNumber;
        }
    }
}