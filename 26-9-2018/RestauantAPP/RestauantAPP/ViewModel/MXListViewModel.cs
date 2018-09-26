using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class MXListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<MX> MX { get; set; }
        public MXListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            MX = new List<MX>(MXData.Get());
        }
        private MX _mxSelected;
        public MX MXSelected
        {
            get { return _mxSelected; }
            set
            {
                if (_mxSelected != value)
                {
                    _mxSelected = value;
                    if ((_mxSelected != null))
                    {
                        _navigation.PushAsync(new MXDetailPage(_mxSelected));
                    }
                }
            }
        }
    }
}


