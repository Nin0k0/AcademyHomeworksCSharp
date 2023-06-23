using FluentValidation;
using Homework_ORM.Domain;

namespace Homework_ORM.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {

        public PersonValidator()
        {
            RuleFor(x => x.CreateDate).LessThan(System.DateTime.Now).WithMessage("CreateDate Can not be more than current Date!")
                .NotNull().WithMessage("CreateDate can not be null!");


            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Firstname can not be empty!")
                .Length(1, 50).WithMessage("FirstName length should be between 1 and 50!");


            RuleFor(x => x.Lastname).NotEmpty().WithMessage("Lastname can not be empty!")
                .Length(1, 50).WithMessage("Lastname length should be between 1 and 50!");


            RuleFor(x => x.JobPosition).NotEmpty().WithMessage("JobPosition can not be empty!")
                .Length(1, 50).WithMessage("JobPosition length should be between 1 and 50!");

            RuleFor(x => x.WorkExperince).NotEmpty().WithMessage("WorkExperience should not be empty!");

            RuleFor(x => x.Salary).InclusiveBetween(0, 10000).WithMessage("Salary should be between 0 and 10 000!");

            RuleFor(x => x.Address.HomeNumber).NotEmpty().WithMessage("HomeNumber should not be empty!");

            RuleFor(x => x.Address.City).NotEmpty().WithMessage("City should not be empty!");

            RuleFor(x => x.Address.Country).NotEmpty().WithMessage("Country should not be empty!");
        }


    }
}
