using FluentValidation;
using Pustok.Business.DTOs.AuthorDtos;

namespace Pustok.Business.Validators.AuthorValidators;

public class AuthorPostDtoValidator : AbstractValidator<AuthorPostDto>
{
    public AuthorPostDtoValidator()
    {
        RuleFor(a => a.Fullname)
            .NotNull()
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(250);
    }
}