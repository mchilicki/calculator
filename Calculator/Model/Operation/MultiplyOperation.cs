using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class MultiplyOperation : TwoArgumentOperation
    {
        public MultiplyOperation(Number firstNumber) : base(firstNumber) { }

        public MultiplyOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.MultiplicationSign;

        public override Number Execute()
        {
            return _firstNumber.Multiply(_secondNumber);
        }
    }
}
