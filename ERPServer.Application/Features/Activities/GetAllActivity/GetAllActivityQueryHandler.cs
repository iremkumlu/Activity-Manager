using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPServer.Application.Features.Activities.GetAllActivity;

internal sealed class GetAllActivityQueryHandler(
    IActivityRepository activityRepository) : IRequestHandler<GetAllActivityQuery, Result<List<Activity>>>
{
    public async Task<Result<List<Activity>>> Handle(GetAllActivityQuery request, CancellationToken cancellationToken)
    {
        List<Activity> activities =
            await activityRepository
            .GetAll()
            .Include(p => p.Project)
            .OrderBy(p => p.Project!.ProjectName)
            .ToListAsync(cancellationToken);

        return activities;
    }
}

