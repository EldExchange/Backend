namespace EldExchange.Domain.Models.DALs;

public class Address : BasicDAL<Guid>
{
    public Address(string zipCode, string streetName, string number)
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

    //public Agency? Agency { get; set; }
    //public string? AgencyId { get; set; }

}

