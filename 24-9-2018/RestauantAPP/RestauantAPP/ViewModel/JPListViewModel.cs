using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestauantAPP.Model;
using RestauantAPP.View;
using Xamarin.Forms;

namespace RestauantAPP.ViewModel
{
    public class JPListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private INavigation _navigation;
        public List<JP> JP { get; set; }
        public JPListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            JP = new List<JP>(JPData.Get());
        }
        private JP _jpSelected;
        public JP JPSelected
        {
            get { return _jpSelected; }
            set
            {
                if (_jpSelected != value)
                {
                    _jpSelected = value;
                    if ((_jpSelected != null))
                    {
                        _navigation.PushAsync(new JPDetailPage(_jpSelected));
                    }
                }
            }
        }
    }
}