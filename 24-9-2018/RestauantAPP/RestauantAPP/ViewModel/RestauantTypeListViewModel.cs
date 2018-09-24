using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class RestauantTypeListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<RestauantType> TypeTitle { get; set; }
        public RestauantTypeListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            TypeTitle = new List<RestauantType>(RestauantTypeData.Get());
        }
        private RestauantType _restauantTypeSelected;
        public RestauantType RestauantTypeSelected
        {
            get { return _restauantTypeSelected; }
            set
            {
                if (_restauantTypeSelected != value)
                {
                    _restauantTypeSelected = value;
                    if ((_restauantTypeSelected != null))
                    {
                        _navigation.PushAsync(new RestauantTypeDetailPage(_restauantTypeSelected));
                    }
                }
            }
        }
    }
}
