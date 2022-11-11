using EldExchange.Domain.Interfaces.IRepositories;
using EldExchange.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
