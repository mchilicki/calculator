using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class MultiplyOperation : BaseOperation
    {
        public MultiplyOperation(Number firstNumber, Number secondNumber) 
            : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Multiply(_secondNumber);
        }
    }
}
