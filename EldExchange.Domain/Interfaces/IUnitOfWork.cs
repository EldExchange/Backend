using EldExchange.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IAgencyRepository  AgencyRepository { get; }

        public ICurrencyRepository CurrencyRepository { get; }
    }
}
