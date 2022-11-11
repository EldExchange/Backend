using EldExchange.Domain.Models.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Domain.Interfaces.IServices
{
    public interface IAgencyService
    {
        Agency GetById(string id);
        IEnumerable<Agency> GetAgencyList();
        void CreateAgency(Agency agency);
        void UpdateAgency(Agency agency);
        void DeleteAgency(string id);
    }
}
