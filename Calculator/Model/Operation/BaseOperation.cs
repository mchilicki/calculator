using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class BaseOperation
    {
        public abstract Number Execute();
        public abstract string OperationSign { get; }

        public static BaseOperation EmptyOperation { get; } = new NullOperation();
    }
}
