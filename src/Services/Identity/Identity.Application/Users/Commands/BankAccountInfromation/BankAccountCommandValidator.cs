using FluentValidation;

namespace sattec.Identity.Application.Users.Commands.BankAccountInformation
{
    public class BankAccountCommandValidator : AbstractValidator<BankAccountCommand>
    {
        public BankAccountCommandValidator()
        {
            RuleFor(v => v.CardNo)
                .Length(16)
                .NotEmpty();

            RuleFor(v => v.AccountNo)
             .Length(16)
             .NotEmpty();

            RuleFor(v => v.IBAN)
             .Length(24)
             .NotEmpty();

        }
    }
}
