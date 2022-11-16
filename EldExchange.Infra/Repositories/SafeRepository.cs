using EldExchange.Domain.Interfaces.IRepositories;
using EldExchange.Domain.Models.DALs;
using EldExchange.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Infra.Repositories
{
    internal class SafeRepository : ISafeRepository
    {

        private readonly EldDbContext _context;

        public SafeRepository(EldDbContext context)
        {
            _context = context;
        }

        public void AddSafe(IEnumerable<Safe> safes)
        {
            _context.Entry(safes).State = EntityState.Added;
            _context.Safe.AddRange(safes);
            _context.SaveChanges();
        }
    }
}
