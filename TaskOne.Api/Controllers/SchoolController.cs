using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskOne.application.Features.Schools.Command.Create;
using TaskOne.application.Features.Schools.Queries.GetAll;

namespace TaskOne.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SchoolController(IMediator mediator) : ControllerBase
	{

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var response = await mediator.Send(new GetSchoolsQuery());
			return Ok(response);
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateSchoolCommand command)
		{
			var success = await mediator.Send(command);
			return success ? NoContent() : BadRequest("Something wrong happened");

		}
	}
}
