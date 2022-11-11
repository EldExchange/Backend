using EldExchange.Domain.Models.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Domain.Interfaces.IRepositories;

public interface IAgencyRepository
{
    Agency GetAgency(string id);
    IEnumerable<Agency> GetAllAgencies();
    void AddAgency(Agency agency);
    void UpdateAgency(Agency agency);
    void DeleteAgency(string id);
}
