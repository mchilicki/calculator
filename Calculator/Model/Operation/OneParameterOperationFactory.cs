using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public static class OneParameterOperationFactory
    {
        public static BaseOperation Create(OperationType operationType, Number number)
        {
            switch (operationType)
            {
                case OperationType.ChangingSign:
                    return new ChangeSignOperation(number);
                case OperationType.SquareExpoment:
                    return new SquareExpomentOperation(number);
                case OperationType.SquareRoot:
                    return new SquareRootOperation(number);
                case OperationType.Addition:
                    return new AddOperation(number);
                case OperationType.Substraction:
                    return new SubstractOperation(number);
                case OperationType.Multiplication:
                    return new MultiplyOperation(number);
                case OperationType.Division:
                    return new DivideOperation(number);
                default:
                    return new NullOperation();
            }
        }
    }
}
