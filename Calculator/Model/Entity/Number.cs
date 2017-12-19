using System;

namespace Calculator.Model.Entity
{
    public class Number
    {
        public double Value { get; set; } = EmptyNumber.Value;        

        public static Number EmptyNumber = new NullNumber();

        public Number(double value)
        {
            Value = value;
        }

        internal Number Add(Number _secondNumber)
        {
            return new Number(this.Value + _secondNumber.Value);
        }

        internal Number ChangeSign()
        {
            return new Number(this.Value * (-1));
        }

        internal Number SquareRoot()
        {
            // Here add something with negative numbers 
            return new Number(Math.Sqrt(this.Value));
        }

        internal Number Substract(Number _secondNumber)
        {
            return new Number(this.Value - _secondNumber.Value);
        }

        internal Number SquareExpoment()
        {            
            return new Number(this.Value * this.Value);
        }

        internal Number Divide(Number _secondNumber)
        {
            // Here add something with zero dividing
            return new Number(this.Value / _secondNumber.Value);
        }

        internal Number Multiply(Number _secondNumber)
        {
            return new Number(this.Value * _secondNumber.Value);
        }
    }
}
