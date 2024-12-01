using MediatR;
using Microsoft.AspNetCore.Mvc;
using PeekStock.API.Features.Users.Commands.Add;
using PeekStock.API.Features.Users.Commands.Update;
using PeekStock.Responses;

namespace PeekStock.API.Controllers;

[ApiController]
[Route("api/user")]
[Produces("application/json")]
public class UserController(IMediator mediator) : ControllerBase
{
	private readonly IMediator _mediator = mediator;

	[HttpPost]
	public async Task<IActionResult> AddUser(
		[FromBody] AddUserCommand command,
		CancellationToken cancellationToken = default)
	{
		var result = await _mediator.Send(command, cancellationToken);
		return DefaultResponses.Success(result);
	}

	[HttpPut("{id:guid}")]
	public async Task<IActionResult> UpdateUser(
		[FromBody] UpdateUserCommand command,
		CancellationToken cancellationToken = default)
	{
		var result = await _mediator.Send(command, cancellationToken);
		return DefaultResponses.Success(result);
	}
}
