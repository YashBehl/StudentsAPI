using DemoWebAPI.Models;
using FluentValidation;

namespace DemoWebAPI.Validator
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.studentName).NotEmpty().WithMessage("Enter name of student").Length(0, 15).WithMessage("Enter length of name between 0 and 15");
            RuleFor(s => s.studentAge).GreaterThanOrEqualTo(20).WithMessage("Age of students should be greater than or equal to 20");
            RuleFor(s => s.studentID).NotNull().WithMessage("Enter id of student: ");
        }
    }
}
