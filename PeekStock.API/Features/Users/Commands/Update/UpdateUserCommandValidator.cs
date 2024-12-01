using FluentValidation;

namespace PeekStock.API.Features.Users.Commands.Update;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
	public UpdateUserCommandValidator()
	{
		RuleFor(x => x.Id)
			.NotEmpty();

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
