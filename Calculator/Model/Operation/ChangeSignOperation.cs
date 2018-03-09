using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class ChangeSignOperation : BaseOperation
    {
        public ChangeSignOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.PlusMinusSign;

        public override Number Execute()
        {
            return null; // TODO Change sign execute
        }
    }
}
