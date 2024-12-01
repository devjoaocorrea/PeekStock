using FluentResults;
using MediatR;
using PeekStock.API.Domain.Entities;
using PeekStock.API.Infraestructure;

namespace PeekStock.API.Features.Users.Commands.Add;

public class AddUserCommandHandler(ApiContext context) : IRequestHandler<AddUserCommand, Result<Guid>>
{
	private readonly ApiContext _context = context;
	public async Task<Result<Guid>> Handle(AddUserCommand request, CancellationToken cancellationToken)
	{
		var user = new User(request.Name, request.Email);
		user.SetPassword(request.Password);

		await _context.Users.AddAsync(user, cancellationToken);
		await _context.SaveChangesAsync(cancellationToken);

		return Result.Ok(user.Id);
	}
}
