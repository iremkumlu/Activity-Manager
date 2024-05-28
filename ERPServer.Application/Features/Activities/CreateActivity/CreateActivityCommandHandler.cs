using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Activities.CreateActivity;

internal sealed class CreateActivityCommandHandler(
    IActivityRepository activityRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<CreateActivityCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
    {
        bool isActivityExists = await activityRepository.AnyAsync(p => p.ProjectId == request.ProjectId, cancellationToken);

        if (isActivityExists)
        {
            return Result<string>.Failure("Bu projeye ait aktivite daha önce oluşturulmuş");
        }

        Activity activity = new()
        {
            ProjectId = request.ProjectId,
            Details = request.Details.Select(s =>
                new ActivityDetail()
                {
                    ProjectId = s.ProjectId,
                    ActivityEntry = s.ActivityEntry
                }).ToList()
        };

        await activityRepository.AddAsync(activity);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Aktivite kaydı başarıyla tamamlandı";
    }
}
