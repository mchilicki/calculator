using Calculator.Properties;

namespace Calculator.Enum
{
    static class OperationTypeExtension
    {
        public static string GetSign(this OperationType operationType)
        {
            switch (operationType)
            {                
                case OperationType.Addition:
                    return Resources.PlusSign;
                case OperationType.Substraction:
                    return Resources.MinusSign;
                case OperationType.Multiplication:
                    return Resources.MultiplicationSign;
                case OperationType.Division:
                    return Resources.DivisionSign;
                case OperationType.ChangingSign:
                    return Resources.PlusMinusSign;
                case OperationType.SquareExponent:
                    return Resources.ExponentSignOnlyNumber;
                case OperationType.SquareRoot:
                    return Resources.RootSign;
                default:
                    return string.Empty;
            }
        }
    }
}
