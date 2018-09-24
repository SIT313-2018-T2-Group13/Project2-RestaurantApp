using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using RestauantAPP.Data;
using RestauantAPP.Model;

namespace RestauantAPP.ViewModel
{
	public class ABListViewModel : INotifyPropertyChanged
    {
                Database _database = new Database();
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<AB> _ablist;

        public ObservableCollection<AB> ABList
        {
            get { return _ablist; }
            set
            {
                _ablist = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ABList"));

            }

        }
        public async Task FetchDataAsync()
        {
            var list = await _database.GetAllSessionAsync();
            ABList = new ObservableCollection<AB>(list);

        }
        public ABListViewModel()
        {
            FetchDataAsync();
        }
    }
}

