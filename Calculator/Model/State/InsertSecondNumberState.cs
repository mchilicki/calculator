using System;
using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.State
{
    class InsertSecondNumberState : CalculationState
    {
        public InsertSecondNumberState(CalculationState calculationState)
        {
            Calculation = calculationState.Calculation;
        }

        public override Number Execute()
        {
            throw new NotImplementedException();
        }

        public override void SetNumber(string number)
        {
            double doubleResult = 0;
            double.TryParse(number, out doubleResult);
            Calculation.SecondNumber.Value = doubleResult;
        }

        protected override void SetOperationType(OperationType operationType)
        {
            throw new NotImplementedException();
        }
    }
}
