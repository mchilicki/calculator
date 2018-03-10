using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class SquareExpomentOperation : BaseOperation
    {
        public SquareExpomentOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.SquareExpoment();
        }
    }
}
