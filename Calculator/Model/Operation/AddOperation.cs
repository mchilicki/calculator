using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class AdditionOperation : TwoArgumentOperation
    {
        public AdditionOperation(Number firstNumber) : base(firstNumber) { }

        public AdditionOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Add(_secondNumber);
        }
    }
}
