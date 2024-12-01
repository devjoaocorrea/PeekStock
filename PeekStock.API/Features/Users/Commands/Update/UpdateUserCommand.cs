using FluentResults;
using MediatR;

namespace PeekStock.API.Features.Users.Commands.Update;

public record UpdateUserCommand(string Id, string Name, string Email, string Password) : IRequest<Result<string>>;
