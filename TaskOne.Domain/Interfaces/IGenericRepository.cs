namespace TaskOne.Domain.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		Task<List<T>> GetAllAsync();
		Task<T> AddAsync(T entity);
		Task<bool> SaveChangesAsync();


	}
}
