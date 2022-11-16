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
        private readonly List<string> _currencyList= new List<string>() { "USD", "BRL", "EUR"};

        public AgencyService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void CreateAgency(AddAgencyDTO agency)
        {
            var currencyList = new List<Currency>();
            _currencyList.ForEach(x => currencyList.Add(_uow.CurrencyRepository.GetCurrency(x)));
            var model = agency.ToMapper<Agency>();


           

            foreach (var currency in currencyList) 
            {
                if(currency.Money != null)
                foreach (var money in currency.Money)
                {
                        var safe = new Safe(model, money, 1000);
                        model.Safes.Add(safe);
                }
            }
            _uow.AgencyRepository.AddAgency(model);
            _uow.SafeRepository.AddSafe(model.Safes);
        }

        public void DeleteAgency(string id) => _uow.AgencyRepository.DeleteAgency(id);
        public IEnumerable<AgencyDTO> GetAgencyList() => _uow.AgencyRepository.GetAllAgencies().ToMapper<IEnumerable<AgencyDTO>>();
        public AgencyDTO? GetById(string id) => _uow.AgencyRepository.GetAgency(id)?.ToMapper<AgencyDTO>();
        public void UpdateAgency(AgencyDTO agency) => _uow.AgencyRepository.UpdateAgency(agency.ToMapper<Agency>());
    }
}
