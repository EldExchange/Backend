namespace EldExchange.Domain.Models.DALs;

public class Currency
{
	public Currency(string currencyCode, string name, string symbol)
	{
		CurrencyCode = currencyCode;
		Name = name;
		Symbol = symbol;
	}
	public string CurrencyCode { get; set; }
	public string Name { get; set; }
	public string Symbol { get; set; }

	public ICollection<Money> Moneys { get; set; } = new List<Money>();
}
