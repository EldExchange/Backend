using EldExchange.Domain.Models.DALs;

namespace EldExchange.Domain.Interfaces.IRepositories
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetCurrencies();
        Currency? GetCurrency(string code);
    }
}
