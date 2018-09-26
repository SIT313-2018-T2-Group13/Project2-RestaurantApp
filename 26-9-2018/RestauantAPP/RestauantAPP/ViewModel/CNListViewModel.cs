using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class CNListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<CN> CN { get; set; }
        public CNListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            CN = new List<CN>(CNData.Get());
        }
        private CN _cnSelected;
        public CN CNSelected
        {
            get { return _cnSelected; }
            set
            {
                if (_cnSelected != value)
                {
                    _cnSelected = value;
                    if ((_cnSelected != null))
                    {
                        _navigation.PushAsync(new CNDetailPage(_cnSelected));
                    }
                }
            }
        }
    }
}