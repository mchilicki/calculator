using System;
using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.State
{
    class InsertFirstNumberState : CalculationState
    {
        protected override void Execute()
        {
            throw new NotImplementedException();
        }

        protected override void InsertDigit(string digit)
        {
            Operation.FirstNumber = new Number(
                Operation.FirstNumber.Value * 
                double.Parse(Properties.Resources.DecimalBase) + 
                double.Parse(digit));
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
