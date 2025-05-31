using MediatR;
using TaskOne.Domain.Entites;
using TaskOne.Domain.Interfaces;

namespace TaskOne.application.Features.Schools.Command.Create
{
	public class CreateSchoolCommandHandler : IRequestHandler<CreateSchoolCommand, bool>
	{
		private readonly IGenericRepository<School> repo;

		public CreateSchoolCommandHandler(IGenericRepository<School> repo)
		{
			this.repo = repo;
		}

		public async Task<bool> Handle(CreateSchoolCommand request, CancellationToken cancellationToken)
		{
			var school = new School { Name = request.Name, CityId = request.CityId };
			await repo.AddAsync(school);
			return await repo.SaveChangesAsync();
		}
	}
}
