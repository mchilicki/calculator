using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class EmptyOperation : BaseOperation
    {
        public EmptyOperation(Number firstNumber, Number secondNumber) 
            : base(firstNumber, secondNumber)
        {
        }

        public override Number Execute()
        {
            return _firstNumber;
        }
    }
}
