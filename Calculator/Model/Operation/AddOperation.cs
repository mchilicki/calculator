using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class AddOperation : TwoArgumentOperation
    {
        public AddOperation(Number firstNumber) : base(firstNumber) { }

        public AddOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.PlusSign;

        public override Number Execute()
        {
            return _firstNumber.Add(SecondNumber);
        }
    }
}
