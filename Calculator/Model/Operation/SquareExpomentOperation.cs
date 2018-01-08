using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class SquareExpomentOperation : FastOperation
    {
        public SquareExpomentOperation(Number number) : base(number) { }

        public override string OperationSign { get; } = Properties.Resources.ExponentSign;

        public override Number Execute()
        {
            return _number.SquareExpoment();
        }
    }
}
