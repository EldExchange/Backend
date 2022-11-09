namespace EldExchange.Domain.Models.DALs;

public class Safe
{
    public Safe(string agencyId, string currencyCode)
    {
        AgencyId = agencyId;
        CurrencyCode = currencyCode;
    }

    public string AgencyId { get; set; }
	public Agency? Agency { get; set; }
	public string CurrencyCode { get; set; }
	public Currency? Currency { get; set; }

}
