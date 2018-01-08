using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    public abstract class FastOperation
    {
        protected Number _number;

        public abstract Number Execute();

        public abstract string OperationSign { get; }

        public static FastOperation EmptyOperation { get; }
                 = new NullFastOperation(Number.EmptyNumber);

        public FastOperation(Number number)
        {
            _number = number;
        }
    }
}
