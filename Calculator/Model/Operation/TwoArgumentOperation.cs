using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class TwoArgumentOperation : BaseOperation
    {
        public Number SecondNumber { get; set; }

        public TwoArgumentOperation(Number firstNumber) : base(firstNumber)
        {
            SecondNumber = Number.EmptyNumber;
        }

        public TwoArgumentOperation(Number firstNumber, Number secondNumber) : base(firstNumber)
        {
            SecondNumber = secondNumber;
        }
    }
}
