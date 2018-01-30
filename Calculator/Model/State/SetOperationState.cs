using System;
using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.State
{
    class SetOperationState : CalculationState
    {
        public SetOperationState(CalculationState calculationState)
        {
            Calculation = calculationState.Calculation;
        }

        public override Number Execute()
        {
            throw new NotImplementedException();
        }

        public override void SetNumber(string number)
        {
            throw new NotImplementedException();
        }

        protected override void SetOperationType(OperationType operationType)
        {
            throw new NotImplementedException();
        }
    }
}
