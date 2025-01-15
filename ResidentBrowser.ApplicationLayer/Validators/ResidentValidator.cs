using FluentValidation;
using ResidentBrowser.DomainLayer.Models;

namespace ResidentBrowser.ApplicationLayer.Validators;

public class ResidentValidator : AbstractValidator<Resident>
{
    public ResidentValidator()
    {
        RuleFor(resident => resident.FirstName)
            .NotEmpty().WithMessage("First name is required.")
            .MaximumLength(50).WithMessage("First name must be a maximum of 50 characters.")
            .Must(value => char.IsUpper(value[0])).WithMessage("First name must start with uppercase letter.");

        RuleFor(resident => resident.LastName)
            .NotEmpty().WithMessage("Last name is required.")
            .MaximumLength(50).WithMessage("Last name must be a maximum of 50 characters.")
            .Must(value => char.IsUpper(value[0])).WithMessage("Last name must start with uppercase letter.");

        RuleFor(resident => resident.PESEL)
            .NotEmpty().WithMessage("PESEL is required.")
            .Length(11).WithMessage("PESEL must be exactly 11 characters long.")
            .Must(value => long.TryParse(value, out _)).WithMessage("PESEL must be of number type.");

        RuleFor(resident => resident.BirthDate)
            .NotEmpty().WithMessage("Birth Date is required.");
    }
}
