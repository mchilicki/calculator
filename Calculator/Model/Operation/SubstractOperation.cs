using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class SubstractionOperation : TwoArgumentOperation
    {
        public SubstractionOperation(Number firstNumber) : base(firstNumber) { }

        public SubstractionOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Substract(_secondNumber);
        }
    }
}
