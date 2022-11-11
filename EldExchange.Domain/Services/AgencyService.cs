using EldExchange.Domain.Interfaces;
using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Domain.Models.DALs;

namespace EldExchange.Domain.Services
{
    internal class AgencyService : IAgencyService
    {
        private readonly IUnitOfWork _uow;

        public AgencyService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void CreateAgency(Agency agency) => _uow.AgencyRepository.AddAgency(agency);
        public void DeleteAgency(string id) => _uow.AgencyRepository.DeleteAgency(id);
        public IEnumerable<Agency> GetAgencyList() => _uow.AgencyRepository.GetAllAgencies();
        public Agency GetById(string id) => _uow.AgencyRepository.GetAgency(id);
        public void UpdateAgency(Agency agency) => _uow.AgencyRepository.UpdateAgency(agency);
    }
}
