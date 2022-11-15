namespace EldExchange.Domain.Models.DALs;

public abstract class Money
{
    public Money(string code, decimal value)
    {
        Value = value;
        Code = code;
    }
    public Currency? Currency { get; set; }
    public string Code { get; set; }
    public decimal Value { get; set; }
    public string? Type { get; set; }
}

public class Coin : Money
{
    public Coin(string code, decimal value) : base(code, value)
    {
        Type = "Coin";
    }
}

public class BankNote : Money
{
    public BankNote(string code, decimal value) : base(code, value)
    {
        Type = "BankNote";
    }
}

