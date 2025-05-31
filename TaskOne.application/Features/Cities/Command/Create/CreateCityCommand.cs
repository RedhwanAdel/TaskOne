using MediatR;
using System.ComponentModel.DataAnnotations;

namespace TaskOne.application.Features.Cities.Command.Create
{
	public class CreateCityCommand : IRequest<bool>
	{
		[Required]
		public string Name { get; set; } = string.Empty;
	}
}
