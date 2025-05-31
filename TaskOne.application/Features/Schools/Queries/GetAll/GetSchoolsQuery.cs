using MediatR;

namespace TaskOne.application.Features.Schools.Queries.GetAll
{
	public class GetSchoolsQuery : IRequest<List<GetSchoolsResponse>>
	{
	}
}
