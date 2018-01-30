using System;
using Calculator.Enum;
using Calculator.Model.Entity;
using Calculator.Model.Operation;

namespace Calculator.Model.State
{
    class InsertFirstNumberState : CalculationState
    {
        public override Number Execute()
        {
            throw new NotImplementedException();
        }

        public override void SetNumber(string number)
        {
            double doubleResult = 0;
            double.TryParse(number, out doubleResult);
            Calculation.FirstNumber.Value = doubleResult;
        }

        protected override void SetOperationType(OperationType operationType)
        {
            Calculation.CalculationState = new SetOperationState(this);
            Calculation.OperationType = operationType;
        }
    }
}
