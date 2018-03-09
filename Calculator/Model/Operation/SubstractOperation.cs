using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class SubstractOperation : BaseOperation
    {
        public SubstractOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.MinusSign;

        public override Number Execute()
        {
            // TODO substract execute
            return _firstNumber.Substract(_secondNumber);
        }
    }
}
