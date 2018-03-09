﻿using Calculator.Enum;
using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;

namespace Calculator.Model.Operation
{
    public static class OperationFactory
    {
        public static BaseOperation Create(OperationType operationType, Number firstNumber, Number secondNumber)
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
                case OperationType.SquareExpoment:
                    return new SquareExpomentOperation(firstNumber, secondNumber);
                case OperationType.SquareRoot:
                    return new SquareRootOperation(firstNumber, secondNumber);
                default:
                    return null;
                // TODO erase null and move it to NullOperation
            }
        }
    }
}
