using EldExchange.Domain.Interfaces.IRepositories;
using EldExchange.Infra.Context;

namespace EldExchange.Infra.Repositories
{
    internal class CurrencyRepository : ICurrencyRepository
    {
        private readonly EldDbContext _context;

        public CurrencyRepository(EldDbContext context)
        {
            _context = context;
        }
    }
}
