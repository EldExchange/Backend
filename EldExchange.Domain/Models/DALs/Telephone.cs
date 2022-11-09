namespace EldExchange.Domain.Models.DALs;

public class Telephone : BasicDAL<string>
{
	public Telephone(string id, string number, string countryCode) : base(id)
	{
		Number = number;
		CountryCode = countryCode;
	}

	public string CountryCode { get; set; }
	public string? RegionCode { get; set; }
	public string Number { get; set; }
	public string? Type { get; set; }

}

