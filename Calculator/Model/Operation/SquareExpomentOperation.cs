using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class SquareExpomentOperation : OneArgumentOperation
    {
        public SquareExpomentOperation(Number number) : base(number) { }

        public override string OperationSign { get; } = Properties.Resources.ExponentSign;

        public override Number Execute()
        {
            return _number.SquareExpoment();
        }
    }
}
