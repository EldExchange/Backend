using EldExchange.Domain.Interfaces.IRepositories;

namespace EldExchange.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAgencyRepository AgencyRepository { get; }

        ICurrencyRepository CurrencyRepository { get; }

        ISafeRepository SafeRepository { get; }
    }
}
