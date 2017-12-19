using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class OneArgumentOperation : Operation
    {
        protected Number _number;

        public OneArgumentOperation(Number number)
        {
            _number = number;
        }
    }
}
