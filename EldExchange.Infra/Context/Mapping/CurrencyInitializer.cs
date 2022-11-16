using EldExchange.Domain.Models.DALs;
using System.Text.Json;

namespace EldExchange.Infra.Context.Mapping;

public static class Initializer
{
    public static IEnumerable<T>? ReadFile<T>(string fileName)
    {
        var startupPath = Directory.GetCurrentDirectory();
        var file = Path.Combine(startupPath, fileName);

        using StreamReader r = new(file);
        var json = r.ReadToEnd();
        var list = JsonSerializer.Deserialize<IEnumerable<T>>(json);
        
        return list;
    }
}

