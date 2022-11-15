using EldExchange.Domain.Interfaces.IRepositories;

namespace EldExchange.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IAgencyRepository AgencyRepository { get; }

        public ICurrencyRepository CurrencyRepository { get; }
    }
}
