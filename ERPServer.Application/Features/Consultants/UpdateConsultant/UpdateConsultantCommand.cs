using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.UpdateConsultant;

public sealed record UpdateConsultantCommand(
    Guid Id,
    string Name,
    string Surname,
    string Phone,
    string City,
    string Department,
    string FullAddress) : IRequest<Result<string>>;

