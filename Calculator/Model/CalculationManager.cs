using Calculator.Model.Entity;
using Calculator.Model.State;
using System.ComponentModel;

namespace Calculator.Model
{
    public class CalculationManager : INotifyPropertyChanged
    {
        private CalculationState _calculationState = new InsertFirstNumberState();                 

        public string OperationSign { get { return _calculationState.OperationSign; } }

        public Number FirstNumber
        {
            get
            {
                return _calculationState.FirstNumber;
            }
            set
            {
                RaisePropertyChanged(nameof(FirstNumber));
            }
        } 

        public Number SecondNumber
        {
            get
            {
                return _calculationState.SecondNumber;
            }
            set
            {
                RaisePropertyChanged(nameof(SecondNumber));
            }
        }

        public Number Execute()
        {
            return _calculationState.Operation.Execute();
        }

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
