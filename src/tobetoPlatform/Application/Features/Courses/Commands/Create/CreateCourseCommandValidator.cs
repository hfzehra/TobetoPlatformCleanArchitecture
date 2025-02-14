using FluentValidation;

namespace Application.Features.Courses.Commands.Create;

public class CreateCourseCommandValidator : AbstractValidator<CreateCourseCommand>
{
    public CreateCourseCommandValidator()
    {
        RuleFor(c => c.EducationPathId).NotEmpty();
        RuleFor(c => c.CourseLessonId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
    }
}