using dotnetcore_litedb.Models;

namespace dotnetcore_litedb.Services
{
    public interface IStakeItemService
    {

        IEnumerable<StakeItem> GetAll();
        StakeItem FindById(int id);
        void Add(StakeItem item);
        void Delete(StakeItem item);
        void Update(StakeItem item);
    }
}
