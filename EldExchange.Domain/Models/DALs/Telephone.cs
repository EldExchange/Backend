namespace EldExchange.Domain.Models.DALs;

public class Telephone : BasicDAL<Guid>
{
    public Telephone(string number, string countryCode)
    {
        Number = number;
        CountryCode = countryCode;
    }

    public string CountryCode { get; set; }
    public string? RegionCode { get; set; }
    public string Number { get; set; }
    public string? Type { get; set; }
    public Guid AgencyId { get; set; }
}

