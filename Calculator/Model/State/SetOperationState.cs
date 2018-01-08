using System;
using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.State
{
    class SetOperationState : CalculationState
    {
        public override Number Execute()
        {
            throw new NotImplementedException();
        }

        public override void InsertDigit(string digit)
        {
            throw new NotImplementedException();
        }

        public override void InsertDot()
        {
            throw new NotImplementedException();
        }

        protected override void SetOperationType(OperationType operationType)
        {
            throw new NotImplementedException();
        }
    }
}
