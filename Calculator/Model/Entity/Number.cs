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
            Value = value + 1;
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
    }
}
