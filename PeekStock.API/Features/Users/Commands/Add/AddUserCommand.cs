using FluentResults;
using MediatR;

namespace PeekStock.API.Features.Users.Commands.Add;

public record AddUserCommand(string Name, string Email, string Password) : IRequest<Result<Guid>>;
