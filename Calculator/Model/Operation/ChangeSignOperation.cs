using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class ChangeSignOperation : FastOperation
    {
        public ChangeSignOperation(Number number) : base(number)
        {
        }

        public override string OperationSign { get; } = Properties.Resources.PlusMinusSign;

        public override Number Execute()
        {
            return _number.ChangeSign();
        }
    }
}
