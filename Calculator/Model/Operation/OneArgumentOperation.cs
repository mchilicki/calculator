using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public abstract class OneArgumentOperation : BaseOperation
    {
        

        public OneArgumentOperation(Number number)
        {
            Number = number;
        }
    }
}
