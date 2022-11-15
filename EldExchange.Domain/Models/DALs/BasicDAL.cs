namespace EldExchange.Domain.Models.DALs;

public abstract class BasicDAL<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey? Id { get; set; }
}

