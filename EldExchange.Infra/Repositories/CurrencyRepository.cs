using EldExchange.Domain.Interfaces.IRepositories;
using EldExchange.Domain.Models.DALs;
using EldExchange.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EldExchange.Infra.Repositories
{
    internal class CurrencyRepository : ICurrencyRepository
    {
        private readonly EldDbContext _context;

        public CurrencyRepository(EldDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return _context.Currencies;//.ToList();
        }

        public Currency? GetCurrency(string code)
        {
            return _context.Currencies.Include(x => x.Money).FirstOrDefault(x => x.Code.Equals(code));
        }
    }
}
