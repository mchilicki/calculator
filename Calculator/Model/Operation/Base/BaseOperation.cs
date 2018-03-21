using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    public abstract class BaseOperation
    {        
        public abstract Number Execute(Number firstNumber, Number secondNumber);
    }
}
