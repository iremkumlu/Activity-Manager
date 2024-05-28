using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using ERPServer.Infrastructure.Context;
using GenericRepository;

namespace ERPServer.Infrastructure.Repositories;
internal sealed class ConsultantRepository : Repository<Consultant, ApplicationDbContext>, IConsultantRepository
{
    public ConsultantRepository(ApplicationDbContext context) : base(context)
    {
    }
}
