using ERPServer.Domain.Abstractions;


namespace ERPServer.Domain.Entities;

public sealed class ActivityDetail : Entity { 
public Guid ActivityId { get; set; }
public Guid ProjectId { get; set; }
public Project? Project { get; set; }
public string ActivityEntry { get; set; } = string.Empty;

}
