namespace Calculator.Model.Entity
{
    public class NullNumber : Number
    {
        public NullNumber()
        {
            Value = 0;
        }

        public NullNumber(double value) : base(value) { }

        internal override Number Add(Number _secondNumber)
        {
            return EmptyNumber;
        }

        internal override Number ChangeSign()
        {
            return EmptyNumber;
        }

        internal override Number SquareRoot()
        { 
            return EmptyNumber;
        }

        internal override Number Substract(Number _secondNumber)
        {
            return EmptyNumber;
        }

        internal override Number SquareExpoment()
        {
            return EmptyNumber;
        }

        internal override Number Divide(Number _secondNumber)
        {
            return EmptyNumber;
        }

        internal override Number Multiply(Number _secondNumber)
        {
            return EmptyNumber;
        }
    }
}
