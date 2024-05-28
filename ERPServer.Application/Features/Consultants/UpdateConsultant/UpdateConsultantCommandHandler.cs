using AutoMapper;
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.UpdateConsultant;

internal sealed class UpdateConsultantCommandHandler(
    IConsultantRepository consultantRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<UpdateConsultantCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateConsultantCommand request, CancellationToken cancellationToken)
    {
        Consultant consultant = await consultantRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (consultant is null)
        {
            return Result<string>.Failure("Danışman bulunamadı");
        }

        mapper.Map(request, consultant);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Danışman bilgileri başarıyla güncellendi";
    }
}

