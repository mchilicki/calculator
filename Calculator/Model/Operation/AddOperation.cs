using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class AddOperation : BaseOperation
    {
        public AddOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.PlusSign;

        public override Number Execute()
        {
            // TODO execute adding
            return _firstNumber.Add(_secondNumber);
        }
    }
}
