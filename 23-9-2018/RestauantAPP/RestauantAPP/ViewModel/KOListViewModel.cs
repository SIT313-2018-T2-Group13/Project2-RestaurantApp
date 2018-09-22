using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class KOListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<KO> KO { get; set; }
        public KOListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            KO = new List<KO>(KOData.Get());
        }
        private KO _koSelected;
        public KO KOSelected
        {
            get { return _koSelected; }
            set
            {
                if (_koSelected != value)
                {
                    _koSelected = value;
                    if ((_koSelected != null))
                    {
                        _navigation.PushAsync(new KODetailPage(_koSelected));
                    }
                }
            }
        }
    }
}