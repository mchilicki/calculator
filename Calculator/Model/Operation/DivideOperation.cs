using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class DivisionOperation : TwoArgumentOperation
    {
        public DivisionOperation(Number firstNumber) : base(firstNumber) { }

        public DivisionOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Divide(_secondNumber);
        }
    }
}
