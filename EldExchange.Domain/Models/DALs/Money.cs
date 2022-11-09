namespace EldExchange.Domain.Models.DALs;

public abstract class Money
{
    public Money(decimal value, string? valueName = null)
    {
        Value = value;
        ValueName = valueName;
    }
    public decimal Value { get; set; }
    public string? ValueName { get; set; }
}

public class Coin : Money
{
    public Coin(decimal value, string? valueName = null) : base(value, valueName)
    {
    }
}

public class BankNote : Money
{
    public BankNote(decimal value, string? valueName = null) : base(value, valueName)
    {
    }
}

