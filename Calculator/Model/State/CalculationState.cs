using Calculator.Model.Entity;
using Calculator.Model.Operation.Base;
using System.ComponentModel;

namespace Calculator.Model.State
{
    public abstract class CalculationState : INotifyPropertyChanged
    {
        private Calculation _calculation;
        public Calculation Calculation
        {
            get
            {
                return _calculation;
            }
            set
            {
                _calculation = value;
            }
        }

        public void SetOperation(Enum.OperationType operationType)
        {
            // set operation sign above
            SetOperationType(operationType);
        }

        protected abstract void SetOperationType(Enum.OperationType operationType);

        public abstract void SetNumber(string number);       

        public abstract Number Execute();        

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
