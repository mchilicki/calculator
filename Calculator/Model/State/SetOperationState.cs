using System;
using Calculator.Enum;

namespace Calculator.Model.State
{
    class SetOperationState : CalculationState
    {
        protected override void Execute()
        {
            throw new NotImplementedException();
        }

        protected override void InsertDigit(string digit)
        {
            throw new NotImplementedException();
        }

        protected override void InsertDot()
        {
            throw new NotImplementedException();
        }

        protected override void SetOperation(OperationType operationType)
        {
            throw new NotImplementedException();
        }
    }
}
