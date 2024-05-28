using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients.DeleteClientById;

public sealed record DeleteClientByIdCommand(
    Guid Id) : IRequest<Result<string>>;

