using TopRankAPI.Controllers;
using TopRankAPI.Entities;

namespace TopRankAPI.DataBaseInstructions{
    public static class DataBase {
        public static void AddItem(RankItem rankItem){
            ApplicationContext db = new ApplicationContext();
            db.RankItems.Add(rankItem);
            db.SaveChanges();
        }

        public static List<RankItem> GetItems(){
            ApplicationContext db = new ApplicationContext();
            List<RankItem> ranks = db.RankItems.ToList();
            return ranks;
        }
        
        public static RankItem BestResult(){
            ApplicationContext db = new ApplicationContext();
            RankItem bestItem = db.RankItems.OrderBy(item => item.Time).FirstOrDefault();
            return bestItem;
        }
    }
}

