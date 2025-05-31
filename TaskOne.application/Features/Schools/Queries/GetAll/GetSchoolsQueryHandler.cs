using MediatR;
using TaskOne.Domain.Entites;
using TaskOne.Domain.Interfaces;

namespace TaskOne.application.Features.Schools.Queries.GetAll
{
	public class GetSchoolsQueryHandler(IGenericRepository<School> repo) : IRequestHandler<GetSchoolsQuery, List<GetSchoolsResponse>>
	{

		public async Task<List<GetSchoolsResponse>> Handle(GetSchoolsQuery request, CancellationToken cancellationToken)
		{
			var schools = await repo.GetAllAsync();
			var schoolsDto = schools.Select(x => new GetSchoolsResponse { Name = x.Name, Id = x.Id });
			return schoolsDto.ToList();
		}
	}
}
