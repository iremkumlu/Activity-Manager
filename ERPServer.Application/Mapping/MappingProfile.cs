using AutoMapper;
using ERPServer.Application.Features.Clients;
using ERPServer.Application.Features.Clients.UpdateClient;
using ERPServer.Application.Features.Consultants.CreateConsultant;
using ERPServer.Application.Features.Consultants.UpdateConsultant;
using ERPServer.Application.Features.Projects.CreateProject;
using ERPServer.Application.Features.Projects.UpdateProject;
using ERPServer.Domain.Entities;

namespace ERPServer.Application.Mapping;

    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateConsultantCommand, Consultant>();
            CreateMap<UpdateConsultantCommand, Consultant>();
            CreateMap<CreateProjectCommand, Project>();
            CreateMap<UpdateProjectCommand, Project>();
            CreateMap<CreateClientCommand, Client>();
            CreateMap<UpdateClientCommand, Client>();
    }
    }
