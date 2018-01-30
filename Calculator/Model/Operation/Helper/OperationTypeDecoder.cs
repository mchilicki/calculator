using Calculator.Enum;

namespace Calculator.Model.Operation.Helper
{
    class OperationTypeDecoder
    {
        public OperationType DetermineOperationType(string operationSign)
        {
            if (operationSign.Equals(Properties.Resources.ExponentSign))
                return OperationType.SquareExpoment;
            if (operationSign.Equals(Properties.Resources.MinusSign))
                return OperationType.Substraction;
            if (operationSign.Equals(Properties.Resources.MultiplicationSign))
                return OperationType.Multiplication;
            if (operationSign.Equals(Properties.Resources.PlusSign))
                return OperationType.Addition;
            if (operationSign.Equals(Properties.Resources.RootSign))
                return OperationType.SquareRoot;
            if (operationSign.Equals(Properties.Resources.DivisionSign))
                return OperationType.Division;
            return OperationType.Undefined;
        }

        public string DetermineOperationSign(OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Addition:
                    return Properties.Resources.PlusSign;
                case OperationType.SquareExpoment:
                    return Properties.Resources.ExponentSign;
                case OperationType.Substraction:
                    return Properties.Resources.MinusSign;
                case OperationType.Multiplication:
                    return Properties.Resources.MultiplicationSign;
                case OperationType.SquareRoot:
                    return Properties.Resources.RootSign;
                case OperationType.Division:
                    return Properties.Resources.DivisionSign;
                default:
                    return "Undefined";
            }
        }
    }
}
