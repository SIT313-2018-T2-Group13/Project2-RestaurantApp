﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class CNDetailsViewModel : INotifyPropertyChanged
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

        private CN _cn;
        //Set the new value to the CN
        public CN CN
        {
            set { SetProperty(ref _cn, value); }
            get { return _cn; }
        }

        public CNDetailsViewModel()
        {

        }

        public void SetData(CN finalsession)
        {
            CN = finalsession;
        }
    }
}
