using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using ERPServer.Infrastructure.Context;
using GenericRepository;

namespace ERPServer.Infrastructure.Repositories;

internal sealed class ActivityRepository : Repository<Activity, ApplicationDbContext>, IActivityRepository
{
    public ActivityRepository(ApplicationDbContext context) : base(context)
    {
    }
}
