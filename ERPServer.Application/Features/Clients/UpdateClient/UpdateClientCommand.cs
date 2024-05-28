using ERPServer.Application.Features.Consultants.UpdateConsultant;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients.UpdateClient;

public sealed record UpdateClientCommand(
    Guid Id,
    string ClientName,
    string ContactPerson,
    string Email) : IRequest<Result<string>>;


