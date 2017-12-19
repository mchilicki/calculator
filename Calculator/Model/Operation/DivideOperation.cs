using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class DivideOperation : TwoArgumentOperation
    {
        public DivideOperation(Number firstNumber) : base(firstNumber) { }

        public DivideOperation(Number firstNumber, Number secondNumber) : base(firstNumber, secondNumber) { }

        public override string OperationSign { get; } = Properties.Resources.DivisionSign;

        public override Number Execute()
        {
            return _firstNumber.Divide(_secondNumber);
        }
    }
}
