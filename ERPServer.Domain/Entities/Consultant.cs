using ERPServer.Domain.Abstractions;

namespace ERPServer.Domain.Entities;
public sealed class Consultant : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string FullAddress { get; set; } = string.Empty;

}
