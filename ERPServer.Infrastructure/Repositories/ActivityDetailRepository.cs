using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using ERPServer.Infrastructure.Context;
using GenericRepository;

namespace ERPServer.Infrastructure.Repositories;

internal sealed class ActivityDetailRepository : Repository<ActivityDetail, ApplicationDbContext>, IActivityDetailRepository
{
    public ActivityDetailRepository(ApplicationDbContext context) : base(context)
    {
    }
}