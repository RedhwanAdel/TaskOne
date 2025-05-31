using MediatR;
using TaskOne.Domain.Entites;
using TaskOne.Domain.Interfaces;

namespace TaskOne.application.Features.Cities.Queries.GetAll
{
	public class GetCitiesQueryHandler(IGenericRepository<City> repo) : IRequestHandler<GetCitiesQuery, List<GetCitiesResponse>>
	{
		public async Task<List<GetCitiesResponse>> Handle(GetCitiesQuery request, CancellationToken cancellationToken)
		{
			var cities = await repo.GetAllAsync();
			var citiesDto = cities.Select(x => new GetCitiesResponse { Id = x.Id, Name = x.Name });
			return citiesDto.ToList();
		}
	}
}
