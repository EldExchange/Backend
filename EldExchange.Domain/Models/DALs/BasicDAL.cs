namespace EldExchange.Domain.Models.DALs;

public abstract class BasicDAL<TKey> 
	where TKey : IEquatable<TKey> 
{
	public BasicDAL(TKey id)
	{
		Id = id;
	}
	public TKey Id { get; set; }
}

