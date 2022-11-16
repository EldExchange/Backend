namespace EldExchange.Domain.Models.DALs;

public class Agency : BasicDAL<Guid>
{
    public Agency(string name, string CNPJ)
    {
        Name = name;
        this.CNPJ = CNPJ;
    }
    public string Name { get; set; }
    public string CNPJ { get; set; }
    public bool IsWorking { get; set; } = false;

    public Address? Address { get; set; }
    public ICollection<Telephone> Phones { get; set; } = new List<Telephone>();
    public ICollection<Safe> Safes { get; set; } = new List<Safe>();
    //public ICollection<Currency> Currencies { get; set; } = new List<Currency>();
}
