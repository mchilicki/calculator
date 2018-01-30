﻿using Calculator.Model.Entity;
using Calculator.Model.State;
using System.ComponentModel;

namespace Calculator.Model
{
    public class CalculationManager : INotifyPropertyChanged
    {
        private CalculationState _calculationState = new InsertFirstNumberState();

                     

        //public string OperationSign { get { return _calculationState.Calculation.OperationSign; } }

        public string FirstNumber
        {
            get
            {
                return _calculationState.Calculation.FirstNumber.ToString();
            }
            set
            {
                _calculationState.SetNumber(value);
                RaisePropertyChanged(nameof(FirstNumber));
            }
        } 

        public string SecondNumber
        {
            get
            {
                return _calculationState.Calculation.SecondNumber.ToString();
            }
            set
            {
                _calculationState.SetNumber(value);
                RaisePropertyChanged(nameof(SecondNumber));
            }
        }

        public Number Execute()
        {
            return _calculationState.Calculation.Operation.Execute();
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
