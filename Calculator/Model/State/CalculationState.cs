using Calculator.Model.Operation;

namespace Calculator.Model.State
{
    public abstract class CalculationState
    {
        public BaseOperation Operation { get; set; }

        protected abstract void InsertDigit(string digit);

        protected abstract void InsertDot();

        protected abstract void SetOperation(Enum.OperationType operationType);

        protected abstract void Execute();
    }
}
