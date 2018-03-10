using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class DivideOperation : BaseOperation
    {
        public DivideOperation(Number firstNumber, Number secondNumber) 
            : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            // TODO execute divide
            return _firstNumber.Divide(_secondNumber);
        }
    }
}
