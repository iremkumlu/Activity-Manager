using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.DeleteConsultantById;

internal sealed class DeleteConsultantByIdCommandHandler(
    IConsultantRepository consultantRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteConsultantByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteConsultantByIdCommand request, CancellationToken cancellationToken)
    {
        Consultant consultant = await consultantRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

        if (consultant is null)
        {
            return Result<string>.Failure("Danışman bulunamadı");
        }

        consultantRepository.Delete(consultant);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Danışman başarıyla silindi";
    }
}

