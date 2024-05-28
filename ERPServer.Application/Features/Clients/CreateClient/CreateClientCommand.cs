using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Clients;

public sealed record CreateClientCommand
(

    string ClientName,
    string ContactPerson,
    string Email ) : IRequest<Result<string>>;





