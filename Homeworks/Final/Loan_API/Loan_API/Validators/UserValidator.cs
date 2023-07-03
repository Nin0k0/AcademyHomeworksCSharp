using FluentValidation;
using Loan_API.Domain;

namespace Loan_API.Validators
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(x => x.Firstname)
                .NotEmpty().WithMessage("Firstname can not be empty!")
                .Length(1, 50).WithMessage("FirstName length should be between 1 and 50!");

            RuleFor(x => x.Lastname)
                .NotEmpty().WithMessage("Lastname can not be empty!")
                .Length(1, 50).WithMessage("Lastname length should be between 1 and 50!");

            RuleFor(x => x.Password)
                .MinimumLength(8).WithMessage("Password Must be at least 8 characters!");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Email must be valid!");

            RuleFor(x => x.Age)
                .LessThanOrEqualTo(17).WithMessage("Customer must be an adult!");

           











        }


    }
}
