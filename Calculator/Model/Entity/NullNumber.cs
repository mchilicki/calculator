namespace Calculator.Model.Entity
{
    public class NullNumber : Number
    {
        public NullNumber()
        {
            Value = 0;
        }

        public NullNumber(double value) : base(value) { }
    }
}
