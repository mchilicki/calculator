using System;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    class ChangingSignOperation : OneArgumentOperation
    {
        public ChangingSignOperation(Number number) : base(number)
        {
        }

        public override Number Execute()
        {
            return _number.ChangeSign();
        }
    }
}
