using Microsoft.EntityFrameworkCore;
using TaskOne.Domain.Entites;

namespace TaskOne.Infrastructure.Data
{
	public class SchoolContext : DbContext
	{
		public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
		{
		}
		public DbSet<City> Cities { get; set; }
		public DbSet<School> Schools { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>()
				.HasMany(s => s.School)
				.WithOne(s => s.City)
				.HasForeignKey(s => s.CityId);
			modelBuilder.Entity<School>()
				.HasOne(s => s.City)
				.WithMany(s => s.School)
				.HasForeignKey(s => s.CityId);
			base.OnModelCreating(modelBuilder);
		}

	}
}
