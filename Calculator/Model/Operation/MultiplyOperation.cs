using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class MultiplicationOperation : TwoArgumentOperation
    {
        public MultiplicationOperation(Number firstNumber) : base(firstNumber) { }

        public MultiplicationOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Multiply(_secondNumber);
        }
    }
}
