using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Activities.DeleteActivityById;

public sealed record DeleteActivityByIdCommand(
    Guid Id) : IRequest<Result<string>>;

internal sealed class DeleteActivityByIdCommandHandler(
    IActivityRepository activityRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteActivityByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteActivityByIdCommand request, CancellationToken cancellationToken)
    {
        Activity activity = await activityRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

        activityRepository.Delete(activity);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Aktivite başarıyla silindi";
    }
}