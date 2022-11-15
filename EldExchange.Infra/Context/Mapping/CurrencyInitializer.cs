using EldExchange.Domain.Models.DALs;
using System.Text.Json;

namespace EldExchange.Infra.Context.Mapping;

public static class CurrencyInitializer
{
    public static IEnumerable<Currency>? Initialize()
    {
        var startupPath = Directory.GetCurrentDirectory();
        var file = Path.Combine(startupPath, "Currency.json");

        using StreamReader r = new(file);
        var json = r.ReadToEnd();
        var currencyList = JsonSerializer.Deserialize<IEnumerable<Currency>>(json)?
            .Where(c=> !string.IsNullOrWhiteSpace(c.Code)).GroupBy(c=> c.Code).Select(c=> c.First()).OrderBy(c => c.Code).ToList();
        
        return currencyList;
    }
}
