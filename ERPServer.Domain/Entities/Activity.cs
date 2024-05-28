using ERPServer.Domain.Abstractions;


namespace ERPServer.Domain.Entities;

public sealed class Activity : Entity
{
    public Guid ProjectId { get; set; }
    public Project? Project { get; set; }
    public DateTime? ActivityStartDate { get; set; }
    public DateTime? ActivityEndDate { get; set; }
    public List<ActivityDetail>? Details { get; set; }
}
