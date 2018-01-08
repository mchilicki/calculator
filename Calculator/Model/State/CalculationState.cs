using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using System.ComponentModel;

namespace Calculator.Model.State
{
    public abstract class CalculationState : INotifyPropertyChanged
    {
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
                RaisePropertyChanged(nameof(FirstNumber));
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
                RaisePropertyChanged(nameof(SecondNumber));
            }
        }

        private string _operationSign;
        public string OperationSign 
                         {
            get
            {
                return _operationSign;
            }
            set
            {
                _operationSign = value;
                RaisePropertyChanged(nameof(OperationSign));
            }
        }  

        public void SetOperation(Enum.OperationType operationType)
        {
            // set operation sign above
            SetOperationType(operationType);
        }

        public abstract void InsertDigit(string digit);

        public abstract void InsertDot();          

        public abstract Number Execute();

        protected abstract void SetOperationType(Enum.OperationType operationType);

        public virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
