using EldExchange.Domain.Config;
using EldExchange.Domain.Interfaces;
using EldExchange.Domain.Interfaces.IServices;
using EldExchange.Domain.Models.DALs;
using EldExchange.Domain.Models.DTOs;

namespace EldExchange.Domain.Services
{
    internal class AgencyService : IAgencyService
    {
        private readonly IUnitOfWork _uow;

        public AgencyService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void CreateAgency(AddAgencyDTO agency) => _uow.AgencyRepository.AddAgency(agency.ToMapper<Agency>());
        public void DeleteAgency(string id) => _uow.AgencyRepository.DeleteAgency(id);
        public IEnumerable<AgencyDTO> GetAgencyList() => _uow.AgencyRepository.GetAllAgencies().ToMapper<IEnumerable<AgencyDTO>>();
        public AgencyDTO? GetById(string id) => _uow.AgencyRepository.GetAgency(id)?.ToMapper<AgencyDTO>();
        public void UpdateAgency(AgencyDTO agency) => _uow.AgencyRepository.UpdateAgency(agency.ToMapper<Agency>());
    }
}
