using Calculator.Enum;
using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    public static class FastOperationFactory
    {
        public static FastOperation Create(OperationType operationType, Number number)
        {
            switch (operationType)
            {
                case OperationType.ChangingSign:
                    return new ChangeSignOperation(number);
                case OperationType.SquareExpoment:
                    return new SquareExpomentOperation(number);
                case OperationType.SquareRoot:
                    return new SquareRootOperation(number);
                default:
                    return new NullFastOperation(Number.EmptyNumber);
            }
        }
    }
}
