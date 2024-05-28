using AutoMapper;
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients.UpdateClient;

internal sealed class UpdateClientCommandHandler(
    IClientRepository clientRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<UpdateClientCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
    {
        Client client = await clientRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (client is null)
        {
            return Result<string>.Failure("Müşteri bulunamadı");
        }

        mapper.Map(request, client);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Müşteri bilgileri başarıyla güncellendi";
    }
}


