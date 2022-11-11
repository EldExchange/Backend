namespace EldExchange.Domain.Models.DALs;

public abstract class Money : BasicDAL<string>
{
    public Money(string id,decimal value, string? valueName = null): base(id)
    {
        Value = value;
        ValueName = valueName;
    }
    public decimal Value { get; set; }
    public string? ValueName { get; set; }
}

public class Coin : Money
{
    public Coin(string id, decimal value, string? valueName = null) : base(id,value, valueName)
    {
    }
}

public class BankNote : Money
{
    public BankNote(string id, decimal value, string? valueName = null) : base(id, value, valueName)
    {
    }
}

