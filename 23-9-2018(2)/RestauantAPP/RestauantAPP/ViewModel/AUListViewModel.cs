using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class AUListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<AU> AU { get; set; }
        public AUListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            AU = new List<AU>(AUData.Get());
        }
        private AU _auSelected;
        public AU AUSelected
        {
            get { return _auSelected; }
            set
            {
                if (_auSelected != value)
                {
                    _auSelected = value;
                    if ((_auSelected != null))
                    {
                        _navigation.PushAsync(new AUDetailPage(_auSelected));
                    }
                }
            }
        }
    }
}
