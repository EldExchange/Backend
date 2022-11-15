using System.ComponentModel.DataAnnotations;

namespace EldExchange.Domain.Models.DALs;

public class Currency
{
    public Currency(string code,string name, string country)
    {
        Name = name;
        Country = country;
        Code = code;
    }

    public string Country { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int? Number { get; set; }
}
