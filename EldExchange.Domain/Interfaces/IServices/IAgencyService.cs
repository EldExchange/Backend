using EldExchange.Domain.Models.DTOs;

namespace EldExchange.Domain.Interfaces.IServices
{
    public interface IAgencyService
    {
        AgencyDTO? GetById(string id);
        IEnumerable<AgencyDTO> GetAgencyList();
        void CreateAgency(AddAgencyDTO agency);
        void UpdateAgency(AgencyDTO agency);
        void DeleteAgency(string id);
    }
}
