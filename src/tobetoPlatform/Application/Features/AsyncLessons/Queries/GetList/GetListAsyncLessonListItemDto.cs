using Core.Application.Dtos;

namespace Application.Features.AsyncLessons.Queries.GetList;

public class GetListAsyncLessonListItemDto : IDto
{
    public int Id { get; set; }
    public int ProfileEducationId { get; set; }
    public int CourseLessonId { get; set; }
    public int LessonVideoDetailId { get; set; }
    public int VideoCategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string VideoUrl { get; set; }
}