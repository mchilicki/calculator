using Calculator.Properties;
using System;

namespace Calculator.Model.Entity
{
    public class Number
    {
        #region Common

        public double Value { get; set; }        

        public Number(double value)
        {
            Value = value;
        }

        public Number(string valueInString)
        {
            double value;
            if (double.TryParse(valueInString, out value))
                Value = value;
        }       

        public override string ToString()
        {
            return Value.ToString();
        }

        #endregion Common

        #region Two Argument Operations

        internal Number Add(Number _secondNumber)
        {
            double result = Value + _secondNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }    

        internal Number Substract(Number _secondNumber)
        {
            double result = Value - _secondNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }

        internal Number Divide(Number _secondNumber)
        {
            if (Value == 0 && _secondNumber.Value == 0)
                throw new ArithmeticException(Resources.ZeroByZeroDividingErrorMessage);
            if (Value != 0 && _secondNumber.Value == 0)
                throw new ArithmeticException(Resources.DividingErrorMessage);
            double result = Value / _secondNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }

        internal Number Multiply(Number _secondNumber)
        {
            double result = Value * _secondNumber.Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }

        #endregion Two Argument Operations

        #region One Argument Operations

        internal Number ChangeSign()
        {
            return new Number(Value * (-1));
        }

        internal Number SquareExpoment()
        {
            double result = Value * Value;
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }

        internal Number SquareRoot()
        {
            if (Value < 0)
                throw new ArithmeticException(Resources.SquareRootErrorMessage);
            double result = Math.Sqrt(Value);
            if (double.IsInfinity(result))
                throw new ArithmeticException(Resources.Infinity);
            return new Number(result);
        }

        #endregion One Argument Operations
    }
}
