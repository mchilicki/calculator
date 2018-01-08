using System;
using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.State
{
    public class InsertFirstNumberState : CalculationState
    {
        public override Number Execute()
        {
            throw new NotImplementedException();
        }

        public override void InsertDigit(string digit)
        {
            FirstNumber = new Number(
                FirstNumber.Value * 
                double.Parse(Properties.Resources.DecimalBase) + 
                double.Parse(digit));
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
