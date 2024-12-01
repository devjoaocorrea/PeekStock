using FluentResults;
using MediatR;
using PeekStock.API.Infraestructure;

namespace PeekStock.API.Features.Users.Commands.Update;

public class UpdateUserCommandHandler(ApiContext context) : IRequestHandler<UpdateUserCommand, Result<string>>
{
	private readonly ApiContext _context = context;

	public async Task<Result<string>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
	{
		var user = await _context.Users.FindAsync(request.Id, cancellationToken);

		if (user is null)
			return Result.Fail(string.Format("User not found: {0}", request.Id));

		user.Edit(request.Name, request.Email, request.Password);

		_context.Users.Update(user);
		await _context.SaveChangesAsync(cancellationToken);

		return Result.Ok("User updated successfully.");
	}
}
