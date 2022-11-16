using EldExchange.Domain.Interfaces;
using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Domain.Models.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Domain.Services
{
    internal class CurrencyService : ICurrencyService
    {
        private readonly IUnitOfWork _uow;

        public CurrencyService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return _uow.CurrencyRepository.GetCurrencies();
        }

        public Currency? GetCurrency(string code)
        {
            return _uow?.CurrencyRepository.GetCurrency(code.ToUpper());
        }
    }
}
