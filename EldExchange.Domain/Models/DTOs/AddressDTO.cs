namespace EldExchange.Domain.Models.DTOs;

public record AddAddressDTO
{
    public AddAddressDTO(string zipCode, string streetName, string number)
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

public record AddressDTO : AddAddressDTO
{
    public AddressDTO(Guid id, string zipCode, string streetName, string number) : base(zipCode, streetName, number)
    {
        Id = id;
    }

    protected AddressDTO(Guid id, AddAddressDTO original) : base(original)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}


