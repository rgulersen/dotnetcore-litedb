using dotnetcore_litedb.Models;
using LiteDB;
namespace dotnetcore_litedb.Services
{
    public class StakeItemService : IStakeItemService
    {
        private readonly LiteDbContext _context;
        private readonly ILiteCollection<StakeItem> _liteCollection;
        public StakeItemService(LiteDbContext context)
        {
            _context = context;
            _liteCollection = _context.LiteDb().GetCollection<StakeItem>("items");
        }

        public IEnumerable<StakeItem> GetAll()
        {
            return _liteCollection.FindAll();
        }


        public StakeItem FindById(int id)
        {
            return _liteCollection.FindById(id);
        }

        public void Add(StakeItem item)
        {
            _liteCollection.Insert(item);
        }

        public void Delete(StakeItem item)
        {
            _liteCollection.Delete(item.Id);
        }

        public void Update(StakeItem item)
        {
            var stakeItem = _liteCollection.FindById(item.Id);
            if (stakeItem != null)
            {
                stakeItem.Apy = item.Apy;
                _liteCollection.Update(stakeItem);
            }
        }

    }
}
