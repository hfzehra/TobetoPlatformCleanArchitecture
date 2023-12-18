using Core.Application.Responses;

namespace Application.Features.Experiences.Queries.GetById;

public class GetByIdExperienceResponse : IResponse
{
    public int Id { get; set; }
    public int CityId { get; set; }
    public string OrganizationName { get; set; }
    public string Position { get; set; }
    public string Sector { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
}