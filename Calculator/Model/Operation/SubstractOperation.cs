using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class SubstractOperation : BaseOperation
    {
        public SubstractOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Substract(_secondNumber);
        }
    }
}
