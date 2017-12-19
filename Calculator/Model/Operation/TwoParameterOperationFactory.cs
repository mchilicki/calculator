﻿using Calculator.Enum;
using Calculator.Model.Entity;

namespace Calculator.Model.Operation
{
    public static class TwoParameterOperationFactory
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
                default:
                    return new NullOperation();
            }
        }
    }
}