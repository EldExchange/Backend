namespace EldExchange.Domain.Models.DTOs;

public record AddAgencyDTO
{
    public AddAgencyDTO(string name, string cNPJ)
    {
        Name = name;
        CNPJ = cNPJ;
    }
    public string Name { get; init; }
    public string CNPJ { get; init; }
    public bool IsWorking { get; init; } = false;
    public AddAddressDTO? Address { get; set; }

}

public record AgencyDTO : AddAgencyDTO
{
    public AgencyDTO(Guid id, string name, string cNPJ) : base(name, cNPJ)
    {
        Id = id;
    }

    protected AgencyDTO(Guid id, AddAgencyDTO original) : base(original)
    {
        Id = id;
    }

    public Guid Id { get; init; }
    public new AddressDTO? Address { get; set; }
}
