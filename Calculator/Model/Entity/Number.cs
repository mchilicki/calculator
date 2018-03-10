using Calculator.Properties;
using System;
using System.Windows;

namespace Calculator.Model.Entity
{
    public class Number
    {
        public double Value { get; set; }        

        protected Number()
        {
        }

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

        internal Number Add(Number _secondNumber)
        {
            return new Number(Value + _secondNumber.Value);
        }

        internal Number ChangeSign()
        {
            return new Number(Value * (-1));
        }

        internal Number SquareRoot()
        {
            if (Value < 0)
                throw new ArithmeticException(Resources.SquareRootErrorMessage);
            return new Number(Math.Sqrt(Value));
        }

        internal Number Substract(Number _secondNumber)
        {
            return new Number(Value - _secondNumber.Value);
        }

        internal Number SquareExpoment()
        {            
            return new Number(Value * Value);
        }

        internal Number Divide(Number _secondNumber)
        {
            if (Value == 0 && _secondNumber.Value == 0)
                throw new ArithmeticException(Resources.ZeroByZeroDividingErrorMessage);
            if (Value != 0 && _secondNumber.Value == 0)
                throw new ArithmeticException(Resources.DividingErrorMessage);
            return new Number(Value / _secondNumber.Value);
        }

        internal Number Multiply(Number _secondNumber)
        {
            return new Number(Value * _secondNumber.Value);
        }
    }
}
