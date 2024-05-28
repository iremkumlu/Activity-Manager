using AutoMapper;
using ERPServer.Domain.Entities;
using ERPServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Projects.CreateProject;

internal sealed class CreateProjectCommandHandler(
    IProjectRepository projectRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateProjectCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        Project project = mapper.Map<Project>(request);

        // SQL Server formatına dönüştürme
        if (project.StartDate.HasValue)
        {
            project.StartDate = DateTime.ParseExact(project.StartDate.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", null);
        }
        if (project.EndDate.HasValue)
        {
            project.EndDate = DateTime.ParseExact(project.EndDate.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", null);
        }

        await projectRepository.AddAsync(project, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Proje başarıyla kaydedildi";
    }
}
