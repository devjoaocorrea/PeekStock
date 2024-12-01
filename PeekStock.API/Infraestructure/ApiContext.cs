using Microsoft.EntityFrameworkCore;
using PeekStock.API.Domain.Entities;
using System.Reflection;

namespace PeekStock.API.Infraestructure;

public class ApiContext(DbContextOptions options) : DbContext(options)
{
	public required DbSet<User> Users { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		// Aciona a configuracao de todas as implementacoes de IEntityTypeConfiguration
		builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		base.OnModelCreating(builder);
	}
}
