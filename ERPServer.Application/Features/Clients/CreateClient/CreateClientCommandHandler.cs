using AutoMapper;
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients;

internal sealed class CreateClientCommandHandler(
    IClientRepository clientRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateClientCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateClientCommand request, CancellationToken cancellationToken)
    {


        Client client = mapper.Map<Client>(request);

        await clientRepository.AddAsync(client, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Müşteri kaydı başarıyla tamamlandı";
    }
}





