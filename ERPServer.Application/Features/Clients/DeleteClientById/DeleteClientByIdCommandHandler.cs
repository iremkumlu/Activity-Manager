
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients.DeleteClientById;

internal sealed class DeleteClientByIdCommandHandler(
    IClientRepository clientRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteClientByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteClientByIdCommand request, CancellationToken cancellationToken)
    {
        Client client = await clientRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

        if (client is null)
        {
            return Result<string>.Failure("Müşteri bulunamadı");
        }

        clientRepository.Delete(client);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Müşteri başarıyla silindi";
    }
}

