using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using Calculator.Properties;
using System;

namespace Calculator.Model.Operation
{
    class DivideOperation : BaseOperation
    {
        public override Number Execute(Number firstNumber, Number secondNumber)
        {
            if (firstNumber.Value == 0 && secondNumber.Value == 0)
                throw new ArithmeticException(Resources.ZeroByZeroDividingErrorMessage);
            if (firstNumber.Value != 0 && secondNumber.Value == 0)
                throw new ArithmeticException(Resources.DividingErrorMessage);
            double result = firstNumber.Value / secondNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }
    }
}
