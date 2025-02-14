using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IProfileRepository : IAsyncRepository<UserProfile, int>, IRepository<UserProfile, int>
{
}