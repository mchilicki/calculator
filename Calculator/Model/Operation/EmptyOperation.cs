using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class EmptyOperation : BaseOperation
    {
        public override Number Execute(Number firstNumber, Number secondNumber)
        {
            return firstNumber;
        }
    }
}
