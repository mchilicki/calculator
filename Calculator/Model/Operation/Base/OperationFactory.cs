using Calculator.Enum;

namespace Calculator.Model.Operation.Base
{
    public static class OperationFactory
    {
        public static BaseOperation Create(OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Addition:
                    return new AddOperation();
                case OperationType.Substraction:
                    return new SubstractOperation();
                case OperationType.Multiplication:
                    return new MultiplyOperation();
                case OperationType.Division:
                    return new DivideOperation();
                case OperationType.ChangingSign:
                    return new ChangeSignOperation();
                case OperationType.SquareExponent:
                    return new SquareExpomentOperation();
                case OperationType.SquareRoot:
                    return new SquareRootOperation();
                default:
                    return new EmptyOperation();
            }
        }
    }
}
