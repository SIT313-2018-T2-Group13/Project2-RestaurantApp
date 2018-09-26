using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;

namespace RestauantAPP.ViewModel
{
    public class RestauantTypeDetailsViewModel : INotifyPropertyChanged
    {
        //Notifies clients that a property value has changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //We use the Generic method to repleace the mutiple repeated logical, "set"
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private RestauantType _restauantType;
        //Set the new value to the Session
        public RestauantType RestauantType
        {
            set { SetProperty(ref _restauantType, value); }
            get { return _restauantType; }
        }

        public RestauantTypeDetailsViewModel()
        {

        }

        public void SetData(RestauantType finalsession)
        {
            RestauantType = finalsession;
        }
    }
}
