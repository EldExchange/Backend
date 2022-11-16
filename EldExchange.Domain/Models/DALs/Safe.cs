namespace EldExchange.Domain.Models.DALs;

public class Safe
{
    public Safe(string code, string type)
    {
        Code = code;
        Type = type;
    }

    public Safe(Agency agency, Money money, int quantity)
    {
        AgencyId= agency.Id;
        Agency = agency;
        Money = money;
        Code = money.Code;
        Type = money.Type ?? string.Empty;
        Value = money.Value;
        Quantity = quantity;
    }

    public Guid? AgencyId { get; set; }
    public Agency? Agency { get; set; }
    public string Code { get; set; }
    public Money? Money { get; set; }
    public int Quantity { get; set; }
    public string Type { get; set; }
    public decimal Value { get; set; }

}
