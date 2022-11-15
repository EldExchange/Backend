using EldExchange.Domain.Models.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Domain.Interfaces.IServices
{
    public interface ICurrencyService
    {
        IEnumerable<Currency> GetCurrencies();
    }
}
