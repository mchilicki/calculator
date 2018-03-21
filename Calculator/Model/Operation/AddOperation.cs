using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using Calculator.Properties;
using System;

namespace Calculator.Model.Operation
{
    public class AddOperation : BaseOperation
    {
        public override Number Execute(Number firstNumber, Number secondNumber)
        {
            double result = firstNumber.Value + secondNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }
    }
}
