using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPServer.Application.Features.Clients.GetAllClient;

internal sealed class GetAllClientQueryHandler(IClientRepository clientRepository) : IRequestHandler<GetAllClientQuery, Result<List<Client>>>
{
    public async Task<Result<List<Client>>> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
    {
        List<Client> clients = await clientRepository.GetAll().OrderBy(p => p.ClientName).ToListAsync(cancellationToken);

        return clients;

    }
}