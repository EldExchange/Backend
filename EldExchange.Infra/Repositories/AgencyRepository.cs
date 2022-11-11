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
            //model.Currencies = null;
            model.Id = Guid.NewGuid().ToString();
            _context.Entry(model).State = EntityState.Added;
            _context.Agencies.Add(model);
            _context.SaveChanges();
        }

        public void DeleteAgency(string id)
        {
            _context.Agencies.Remove(GetAgency(id));
            _context.SaveChanges();
        }

        public Agency GetAgency(string id)
        {
            return _context.Agencies.FirstOrDefault(x => x.Id == id);
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
