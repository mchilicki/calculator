using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using Calculator.Properties;
using System;

namespace Calculator.Model.Operation
{
    class SquareRootOperation : BaseOperation
    {
        public override Number Execute(Number firstNumber, Number secondNumber)
        {
            if (firstNumber.Value < 0)
                throw new ArithmeticException(Resources.SquareRootErrorMessage);
            double result = Math.Sqrt(firstNumber.Value);
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }
    }
}
