using Core.Application.Dtos;

namespace Application.Features.Courses.Queries.GetList;

public class GetListCourseListItemDto : IDto
{
    public int Id { get; set; }
    public int EducationPathId { get; set; }
    public int CourseLessonId { get; set; }
    public string Name { get; set; }
}