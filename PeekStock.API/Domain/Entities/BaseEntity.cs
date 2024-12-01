namespace PeekStock.API.Domain.Entities;

public abstract class BaseEntity
{
	public Guid Id { get; protected set; }
	public DateTime IncludeDate { get; protected set; } = DateTime.Now;
	public DateTime? AlterDate { get; protected set; } = null;
	public bool IsDeleted { get; protected set; } = false;
}
