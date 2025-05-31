using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TaskOne.application.Features.Schools.Command.Create
{
	public class CreateSchoolCommand : IRequest<bool>
	{
		[Required]
		public string Name { get; set; } = string.Empty;
		[Required]

		public Guid CityId { get; set; }
	}
}
