using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using RestauantAPP.Data;
using RestauantAPP.Model;

namespace RestauantAPP.ViewModel
{
    public class NoticeViewModel: INotifyPropertyChanged
    {
        NoticeManager noticeManager = new NoticeManager();
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Notice> _sessionslist;
        public ObservableCollection<Notice> SessionsList
        {
            get { return _sessionslist; }
            set
            {
                _sessionslist = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SessionsList"));
                }
            }
        }
        public async Task FetchDataAsync()
        {
            var list = await noticeManager.FetchSessionsAsync();
            SessionsList = new ObservableCollection<Notice>(list);
        }
        public NoticeViewModel()
        {
            FetchDataAsync();
        }
    }
}
