namespace EldExchange.Domain.Models.DALs;

public class Safe
{
    public Safe(string agencyId, string code)
    {
        AgencyId = agencyId;
        Code = code;
    }

    public string AgencyId { get; set; }
    public Agency? Agency { get; set; }
    public string Code { get; set; }
    public Money? Money { get; set; }
    public int Quantity { get; set; }
    public decimal Value { get; set; }

}
