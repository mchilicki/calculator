using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public static class OneParameterOperationFactory
    {
        public static Operation Create(OperationType operationType, Number number)
        {
            switch (operationType)
            {
                case OperationType.ChangingSign:
                    return new ChangingSignOperation(number);
                case OperationType.SquareExpoment:
                    return new SquareExpomentOperation(number);
                case OperationType.SquareRoot:
                    return new SquareRootOperation(number);
                case OperationType.Addition:
                    return new AdditionOperation(number);
                case OperationType.Substraction:
                    return new SubstractionOperation(number);
                case OperationType.Multiplication:
                    return new MultiplicationOperation(number);
                case OperationType.Division:
                    return new DivisionOperation(number);
                default:
                    return new NullOperation();
            }
        }
    }
}
