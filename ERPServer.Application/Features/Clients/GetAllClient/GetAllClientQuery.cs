
using ERPServer.Application.Features.Consultants.GetAllConsultant;
using ERPServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients.GetAllClient;


public sealed record GetAllClientQuery() : IRequest<Result<List<Client>>>;
