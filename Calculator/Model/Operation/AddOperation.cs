﻿using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    class AddOperation : BaseOperation
    {
        public AddOperation(Number firstNumber, Number secondNumber)
            : base(firstNumber, secondNumber) { }

        public override Number Execute()
        {
            return _firstNumber.Add(_secondNumber);
        }
    }
}
