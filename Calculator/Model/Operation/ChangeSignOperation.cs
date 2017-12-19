using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class ChangeSignOperation : OneArgumentOperation
    {
        public ChangeSignOperation(Number number) : base(number)
        {
        }

        public override string OperationSign { get; } = Properties.Resources.PlusMinusSign;

        public override Number Execute()
        {
            return Number.ChangeSign();
        }
    }
}
