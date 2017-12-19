using System;

namespace Calculator.Model.Entity
{
    public class Number
    {
        public double Value { get; set; }        

        public static Number EmptyNumber = new NullNumber();

        protected Number()
        {
 //           Value = ;
        }

        public Number(double value)
        {
            Value = value;
        }

        internal virtual Number Add(Number _secondNumber)
        {
            return new Number(this.Value + _secondNumber.Value);
        }

        internal virtual Number ChangeSign()
        {
            return new Number(this.Value * (-1));
        }

        internal virtual Number SquareRoot()
        {
            // Here add something with negative numbers 
            return new Number(Math.Sqrt(this.Value));
        }

        internal virtual Number Substract(Number _secondNumber)
        {
            return new Number(this.Value - _secondNumber.Value);
        }

        internal virtual Number SquareExpoment()
        {            
            return new Number(this.Value * this.Value);
        }

        internal virtual Number Divide(Number _secondNumber)
        {
            // Here add something with zero dividing
            return new Number(this.Value / _secondNumber.Value);
        }

        internal virtual Number Multiply(Number _secondNumber)
        {
            return new Number(this.Value * _secondNumber.Value);
        }
    }
}
