using System.ComponentModel;

namespace Calculator.ViewModel.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Raises the PropertyChange event for the property specified
        /// </summary>
        /// <param name="propertyName">Property name to update. Is case-sensitive.</param>
        public virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        /// <summary>
        /// Raised when a property on this object has a new value.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
