using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public static class TwoParameterOperationFactory
    {
        public static Operation Create(OperationType operationType, Number firstNumber, Number secondNumber)
        {
            switch (operationType)
            {
                case OperationType.Addition:
                    return new AdditionOperation(firstNumber, secondNumber);
                case OperationType.Substraction:
                    return new SubstractionOperation(firstNumber, secondNumber);
                case OperationType.Multiplication:
                    return new MultiplicationOperation(firstNumber, secondNumber);
                case OperationType.Division:
                    return new DivisionOperation(firstNumber, secondNumber);
                default:
                    return new NullOperation();
            }
        }
    }
}
