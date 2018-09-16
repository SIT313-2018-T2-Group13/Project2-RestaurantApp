using MarcTron.Plugin.MTSql;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using CFSessionDB.Model;

namespace CFSessionDB.Data
{
    public class FoodCategory
    {   //generate a property of database.CF_database

        public SQLiteAsyncConnection CF_database { get; private set; }

        public FoodCategory()
        {
            CF_database = MTSql.Current.GetConnectionAsync("w7lab.db");
            CF_database.CreateTableAsync<FoodSession>().Wait();
            CF_database.InsertAsync(new FoodSession { FoodTitle = "Pizza"});
            CF_database.InsertAsync(new FoodSession { FoodTitle = "Burger"});
            CF_database.InsertAsync(new FoodSession { FoodTitle = "Chinese"});
            CF_database.InsertAsync(new FoodSession { FoodTitle = "korean" });
            CF_database.InsertAsync(new FoodSession { FoodTitle = "Japanese" });
            CF_database.InsertAsync(new FoodSession { FoodTitle = "Buffet" });
        }

        public async Task<List<FoodSession>> GetAllSessionAsync()
        {
            return await CF_database.Table<FoodSession>().ToListAsync();
        }
        public async Task AddSessionsAsync(FoodSession newSession)
        {
            await CF_database.InsertAsync(newSession);
        }

    }
}
