namespace EldExchange.Domain.Models.DALs;

public class Address : BasicDAL<string>
{
	public Address(string id, string zipCode, string streetName, string number) : base(id)
	{
		ZipCode = zipCode;
		StreetName = streetName;
		Number = number;
	}
	public string ZipCode { get; set; }
	public string StreetName { get; set; }
	public string Number { get; set; }
	public string? Complement { get; set; }
	public string Country { get; set; } = "Br";
	public string? City { get; set; }

}

