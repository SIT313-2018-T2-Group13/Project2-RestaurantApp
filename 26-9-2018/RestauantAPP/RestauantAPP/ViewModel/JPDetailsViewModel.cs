using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class JPDetailsViewModel : INotifyPropertyChanged
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

        private JP _jp;
        //Set the new value to the JP
        public JP JP
        {
            set { SetProperty(ref _jp, value); }
            get { return _jp; }
        }

        public JPDetailsViewModel()
        {

        }

        public void SetData(JP finalsession)
        {
            JP = finalsession;
        }
    }
}

