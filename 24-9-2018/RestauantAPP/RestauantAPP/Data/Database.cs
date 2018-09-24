using MarcTron.Plugin.MTSql;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestauantAPP.Model;

namespace RestauantAPP.Data
{
    public class Database 
    {
        public SQLiteAsyncConnection CF_database { get; private set; }

        public Database()
        {

            CF_database = MTSql.Current.GetConnectionAsync("RS.db");
            CF_database.CreateTableAsync<AB>().Wait();
            CF_database.InsertAsync(new AB { SessionTitle = "PARIS", SessionDescription = "Project Manager" });
            CF_database.InsertAsync(new AB { SessionTitle = "KIM", SessionDescription = "Developer" });
            CF_database.InsertAsync(new AB { SessionTitle = "WOODY", SessionDescription = "Developer" });
        }

        public async Task<List<AB>> GetAllSessionAsync()
        {
            return await CF_database.Table<AB>().ToListAsync();
        }
        public async Task AddSessionsAsync(AB newSession)
        {
            await CF_database.InsertAsync(newSession);
        }


    }
}

