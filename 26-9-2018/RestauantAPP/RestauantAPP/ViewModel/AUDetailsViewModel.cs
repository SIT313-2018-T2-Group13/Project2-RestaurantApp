using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class AUDetailsViewModel : INotifyPropertyChanged
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

        private AU _au;
        //Set the new value to the AU
        public AU AU
        {
            set { SetProperty(ref _au, value); }
            get { return _au; }
        }

        public AUDetailsViewModel()
        {

        }

        public void SetData(AU finalsession)
        {
            AU = finalsession;
        }
    }
}
