using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class SquareRootOperation : OneArgumentOperation
    {
        public SquareRootOperation(Number number) : base(number) { }

        public override Number Execute()
        {
            return _number.SquareRoot();
        }
    }
}
