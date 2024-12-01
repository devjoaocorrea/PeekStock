using FluentValidation;

namespace PeekStock.API.Features.Users.Commands.Add;

public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
{
	public AddUserCommandValidator()
	{
		RuleFor(x => x.Name)
			.NotEmpty()
			.MinimumLength(4)
			.MaximumLength(100);

		RuleFor(x => x.Name)
			.NotEmpty()
			.MinimumLength(6)
			.MaximumLength(100);

		RuleFor(x => x.Password)
			.NotEmpty()
			.MinimumLength(4);
	}
}
