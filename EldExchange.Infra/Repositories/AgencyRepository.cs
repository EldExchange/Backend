using EldExchange.CrossCutting.Exceptions;
using EldExchange.Domain.Interfaces.IRepositories;
using EldExchange.Domain.Models.DALs;
using EldExchange.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EldExchange.Infra.Repositories
{
    internal class AgencyRepository : IAgencyRepository
    {
        private readonly EldDbContext _context;

        public AgencyRepository(EldDbContext context)
        {
            _context = context;
        }

        public void AddAgency(Agency model)
        {
            _context.Entry(model).State = EntityState.Added;
            _context.Agencies.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgency(string id)
        {
            var model = GetAgency(id);
            if (model == null) throw new NotFoundException("Agency");
            _context.Entry(model).State = EntityState.Deleted;
            _context.Agencies.Remove(model);
            _context.SaveChanges();
        }

        public Agency? GetAgency(string id)
        {
            return _context.Agencies.FirstOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<Agency> GetAllAgencies()
        {
            return _context.Agencies.ToList();
        }

        public void UpdateAgency(Agency model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.Agencies.Update(model);
            _context.SaveChanges();
        }
    }
}
