
namespace ERPServer.Domain.Dtos;


public sealed record ActivityDetailDto(
    Guid ProjectId,
    string ActivityEntry);