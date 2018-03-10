using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation.Base
{
    public static class OperationFactory
    {
        public static BaseOperation Create(Number firstNumber, Number secondNumber, OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Addition:
                    return new AddOperation(firstNumber, secondNumber);
                case OperationType.Substraction:
                    return new SubstractOperation(firstNumber, secondNumber);
                case OperationType.Multiplication:
                    return new MultiplyOperation(firstNumber, secondNumber);
                case OperationType.Division:
                    return new DivideOperation(firstNumber, secondNumber);
                case OperationType.ChangingSign:
                    return new ChangeSignOperation(firstNumber, secondNumber);
                case OperationType.SquareExponent:
                    return new SquareExpomentOperation(firstNumber, secondNumber);
                case OperationType.SquareRoot:
                    return new SquareRootOperation(firstNumber, secondNumber);
                default:
                    return new EmptyOperation(firstNumber, secondNumber);
            }
        }
    }
}
