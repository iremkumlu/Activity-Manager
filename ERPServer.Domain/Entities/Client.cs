using ERPServer.Domain.Abstractions;

namespace ERPServer.Domain.Entities;

public sealed class Client : Entity
{
    public string ClientName { get; set; } = string.Empty;
    public string ContactPerson { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    //public ICollection<Project> Projects { get; set; } = new List<Project>();


}
