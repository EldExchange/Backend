namespace EldExchange.Domain.Models.DALs;

public class Agency : BasicDAL<string>
{
	public Agency(string id, string name, string cnpj) : base(id)
	{
		Name = name;
		CNPJ = cnpj;
	}
	public string Name { get; set; }
	public string CNPJ { get; set; }
	public bool IsWorking { get; set; } = false;

	public Address? Address { get; set; }
	public ICollection<Telephone> Phones { get; set; } = new List<Telephone>();
	public ICollection<Safe> Safes { get; set; } = new List<Safe>();
}
