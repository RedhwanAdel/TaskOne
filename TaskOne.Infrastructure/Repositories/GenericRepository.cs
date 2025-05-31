using Microsoft.EntityFrameworkCore;
using TaskOne.Domain.Interfaces;
using TaskOne.Infrastructure.Data;

namespace TaskOne.Infrastructure.Repositories
{
	public class GenericRepository<T>(SchoolContext context) : IGenericRepository<T> where T : class
	{
		public async Task<T> AddAsync(T entity)
		{
			await context.Set<T>().AddAsync(entity);
			return entity;
		}

		public Task<List<T>> GetAllAsync()
		{
			return context.Set<T>().ToListAsync();
		}

		public async Task<bool> SaveChangesAsync()
		{
			return await context.SaveChangesAsync() > 0;
		}
	}
}
