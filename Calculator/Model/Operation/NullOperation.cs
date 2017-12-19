using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public class NullOperation : Operation
    {
        public override Number Execute()
        {
            return Number.EmptyNumber;
        }
    }
}