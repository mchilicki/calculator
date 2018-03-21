using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using Calculator.Properties;
using System;

namespace Calculator.Model.Operation
{
    class SquareExpomentOperation : BaseOperation
    {
        public override Number Execute(Number firstNumber, Number secondNumber)
        {
            double result = firstNumber.Value * firstNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }
    }
}
