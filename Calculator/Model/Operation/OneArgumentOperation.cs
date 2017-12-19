using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class OneArgumentOperation : BaseOperation
    {
        public Number _number;

        public OneArgumentOperation(Number number)
        {
            _number = number;
        }
    }
}
