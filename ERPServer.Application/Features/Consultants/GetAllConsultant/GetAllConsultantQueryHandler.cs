using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.GetAllConsultant;

internal sealed class GetAllConsultantQueryHandler(IConsultantRepository consultantRepository) : IRequestHandler<GetAllConsultantQuery, Result<List<Consultant>>>
{
    public async Task<Result<List<Consultant>>> Handle(GetAllConsultantQuery request, CancellationToken cancellationToken)
    {
        List<Consultant> consultants = await consultantRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);

        return consultants;

    }
}
    

