using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskOne.application.Features.Cities.Command.Create;
using TaskOne.application.Features.Cities.Queries.GetAll;

namespace TaskOne.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CityController(IMediator mediator) : ControllerBase
	{

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var response = await mediator.Send(new GetCitiesQuery());
			return Ok(response);
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateCityCommand command)
		{
			var success = await mediator.Send(command);
			return success ? NoContent() : BadRequest("Something wrong happened");

		}
	}
}
