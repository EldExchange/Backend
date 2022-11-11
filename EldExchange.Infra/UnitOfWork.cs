using EldExchange.Domain.Interfaces;
using EldExchange.Domain.Interfaces.IRepositories;
using EldExchange.Infra.Context;
using EldExchange.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EldDbContext _context;

        public UnitOfWork(EldDbContext context)
        {
            _context = context;
        }

        private IAgencyRepository? _agencyRepository;
        public IAgencyRepository AgencyRepository
        {
            get
            {
                if (_agencyRepository != null) return _agencyRepository;
                _agencyRepository = new AgencyRepository(_context);
                return _agencyRepository;
            }
        }

        private ICurrencyRepository? _currencyRepository;
        public ICurrencyRepository CurrencyRepository
        {
            get
            {
                if(_currencyRepository != null) return _currencyRepository;
                _currencyRepository = new CurrencyRepository(_context);
                return _currencyRepository;
            }
        }
    }
}
