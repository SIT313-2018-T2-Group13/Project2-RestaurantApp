using System;
using SQLite;

namespace RestauantAPP.Model
{
    public class AB
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string SessionTitle { get; set; }

        public string SessionDescription { get; set; }

        public AB()
        {
        }

        public AB(string SessionTitle, string SessionDescription)
        {
            this.SessionTitle = SessionTitle;
            this.SessionDescription = SessionDescription;
        }
    }
}

