﻿using System;

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

        internal virtual Number Add(Number _secondNumber)
        {
            return new Number(Value + _secondNumber.Value);
        }

        internal virtual Number ChangeSign()
        {
            return new Number(Value * (-1));
        }

        internal virtual Number SquareRoot()
        {
            // TODO Here add something with negative numbers 
            return new Number(Math.Sqrt(Value));
        }

        internal virtual Number Substract(Number _secondNumber)
        {
            return new Number(Value - _secondNumber.Value);
        }

        internal virtual Number SquareExpoment()
        {            
            return new Number(Value * Value);
        }

        internal virtual Number Divide(Number _secondNumber)
        {
            // TODO Here add something with zero dividing
            return new Number(Value / _secondNumber.Value);
        }

        internal virtual Number Multiply(Number _secondNumber)
        {
            return new Number(Value * _secondNumber.Value);
        }
    }
}
