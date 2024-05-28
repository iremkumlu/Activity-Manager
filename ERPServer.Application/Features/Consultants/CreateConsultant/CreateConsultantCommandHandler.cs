using AutoMapper;
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.CreateConsultant;

internal sealed class CreateConsultantCommandHandler(
    IConsultantRepository consultantRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateConsultantCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateConsultantCommand request, CancellationToken cancellationToken)
    {
        

        Consultant consultant = mapper.Map<Consultant>(request);

        await consultantRepository.AddAsync(consultant, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Danışman kaydı başarıyla tamamlandı";
    }
}