using CFSessionDB.Model;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CFSessionDB.Data;
using Xamarin.Forms;
using System.Collections.Generic;
using System;
using CFSessionDB.View;

namespace CFSessionDB.ViewModel
{
    public class SessionListViewModel : INotifyPropertyChanged
    {
        FoodCategory _database = new FoodCategory();
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<FoodSession> _sessionslist;

        public ObservableCollection<FoodSession> FoodSessionsList
        {
            get { return _sessionslist; }
            set
            {
                _sessionslist = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FoodSessionsList"));
                
            }
        }

        private INavigation _navigation;
        public SessionListViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        private FoodSession _selectedFood;
        public FoodSession SelecetedFood 
        {
            get { return _selectedFood; }
            set
            {
                if (_selectedFood != value)
                {
                    _selectedFood = value;

                    //Go to restaurant list page
                    //_navigation.PushAsync(new RestauantList(_selectedFood));
                }
            }
        }

        public async Task FetchDataAsync()
        {
            var list = await _database.GetAllSessionAsync();
            FoodSessionsList = new ObservableCollection<FoodSession>(list);

        }
        public SessionListViewModel()
        {
            FetchDataAsync();
        }
        
    }
}