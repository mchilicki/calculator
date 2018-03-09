using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class MultiplyOperation : BaseOperation
    {
        public MultiplyOperation(Number firstNumber, Number secondNumber) 
            : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.MultiplicationSign;

        public override Number Execute()
        {
            // TODO multiply execute
            return _firstNumber.Multiply(_secondNumber);
        }
    }
}
