using FluentValidation;

namespace Application.Features.Courses.Commands.Update;

public class UpdateCourseCommandValidator : AbstractValidator<UpdateCourseCommand>
{
    public UpdateCourseCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.EducationPathId).NotEmpty();
        RuleFor(c => c.CourseLessonId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
    }
}