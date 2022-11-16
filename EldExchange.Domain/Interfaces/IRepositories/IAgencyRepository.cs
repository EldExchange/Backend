using EldExchange.Domain.Models.DALs;

namespace EldExchange.Domain.Interfaces.IRepositories;

public interface IAgencyRepository
{
    Agency? GetAgency(string id);
    IEnumerable<Agency> GetAllAgencies();
    void AddAgency(Agency agency);
    void UpdateAgency(Agency agency);
    void DeleteAgency(string id);
}
