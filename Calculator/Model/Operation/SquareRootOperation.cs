using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class SquareRootOperation : FastOperation
    {
        public SquareRootOperation(Number number) : base(number) { }

        public override string OperationSign { get; } = Properties.Resources.RootSign;

        public override Number Execute()
        {
            return _number.SquareRoot();
        }
    }
}
