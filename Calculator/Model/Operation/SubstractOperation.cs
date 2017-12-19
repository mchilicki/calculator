using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class SubstractOperation : TwoArgumentOperation
    {
        public SubstractOperation(Number firstNumber) : base(firstNumber) { }

        public SubstractOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.MinusSign;

        public override Number Execute()
        {
            return _firstNumber.Substract(_secondNumber);
        }
    }
}
