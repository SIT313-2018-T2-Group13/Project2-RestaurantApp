using SQLite;

namespace CFSessionDB.Model
{
   public class FoodSession
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string FoodTitle { get; set; }

        public FoodSession(){
        }

        public FoodSession(string FoodTitle)
        {
            this.FoodTitle = FoodTitle;
        }
    }
}
