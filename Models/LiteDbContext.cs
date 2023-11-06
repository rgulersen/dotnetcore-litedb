using LiteDB;
namespace dotnetcore_litedb.Models
{
    public class LiteDbContext
    {
        private readonly LiteDatabase _db;
        public LiteDbContext()
        {
            _db = new LiteDatabase("Staking.db");
        }
        public LiteDatabase LiteDb() => _db;
    }
}
