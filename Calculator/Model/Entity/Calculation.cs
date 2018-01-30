using Calculator.Enum;
using Calculator.Model.Operation.Base;
using Calculator.Model.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Entity
{
    public class Calculation
    {
        public CalculationState CalculationState = new InsertFirstNumberState();

        public BaseOperation Operation { get; set; }

        public FastOperation FastOperation { get; set; }

        private Number _firstNumber;
        public Number FirstNumber
        {
            get
            {
                return _firstNumber;
            }
            set
            {
                _firstNumber = value;
               // RaisePropertyChanged(nameof(FirstNumber));
            }
        }

        private Number _secondNumber;
        public Number SecondNumber
        {
            get
            {
                return _secondNumber;
            }
            set
            {
                _secondNumber = value;
               // RaisePropertyChanged(nameof(SecondNumber));
            }
        }

        private OperationType _operationType;
        public OperationType OperationType
        {
            get
            {
                return _operationType;
            }
            set
            {
                _operationType = value;
                // RaisePropertyChanged(nameof(OperationType));
            }
        }
    }
}
