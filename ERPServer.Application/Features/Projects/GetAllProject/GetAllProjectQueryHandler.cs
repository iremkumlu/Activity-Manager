

using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace ERPServer.Application.Features.Projects.GetAllProject;

internal sealed class GetAllProjectQueryHandler(
    IProjectRepository projectRepository) : IRequestHandler<GetAllProjectQuery, Result<List<Project>>>
{
    public async Task<Result<List<Project>>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
    {
        List<Project> projects = await projectRepository.GetAll().OrderBy(p => p.ProjectName).ToListAsync(cancellationToken);

        return projects;
    }
}
