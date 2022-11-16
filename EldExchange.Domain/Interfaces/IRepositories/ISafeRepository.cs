using EldExchange.Domain.Models.DALs;

namespace EldExchange.Domain.Interfaces.IRepositories
{
    public interface ISafeRepository
    {
        void AddSafe(IEnumerable<Safe> safes);
    }
}
