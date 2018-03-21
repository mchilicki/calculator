using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class ChangeSignOperation : BaseOperation
    {
        public override Number Execute(Number firstNumber, Number secondNumber)
        {
            return new Number(firstNumber.Value * (-1));
        }
    }
}
