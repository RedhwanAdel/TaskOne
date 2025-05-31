using MediatR;
using TaskOne.Domain.Entites;
using TaskOne.Domain.Interfaces;

namespace TaskOne.application.Features.Cities.Command.Create
{
	public class CreateCityCommandHandler(IGenericRepository<City> repo) : IRequestHandler<CreateCityCommand, bool>
	{
		public async Task<bool> Handle(CreateCityCommand request, CancellationToken cancellationToken)
		{
			var city = new City { Name = request.Name };
			await repo.AddAsync(city);
			return await repo.SaveChangesAsync();
		}
	}
}
