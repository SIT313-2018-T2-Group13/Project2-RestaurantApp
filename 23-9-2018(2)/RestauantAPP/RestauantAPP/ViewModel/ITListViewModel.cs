using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class ITListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<IT> IT { get; set; }
        public ITListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            IT = new List<IT>(ITData.Get());
        }
        private IT _itSelected;
        public IT ITSelected
        {
            get { return _itSelected; }
            set
            {
                if (_itSelected != value)
                {
                    _itSelected = value;
                    if ((_itSelected != null))
                    {
                        _navigation.PushAsync(new ITDetailPage(_itSelected));
                    }
                }
            }
        }
    }
}