using MediatR;

namespace TaskOne.application.Features.Cities.Queries.GetAll
{
	public class GetCitiesQuery : IRequest<List<GetCitiesResponse>>
	{
	}
}
