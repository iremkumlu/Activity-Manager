using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.CreateConsultant;

public sealed record CreateConsultantCommand(
string Name,
string Surname,
string Phone,
string City,
string Department,
string FullAddress) : IRequest<Result<string>>;
