using Danilvar.Entity;
using DVar.BLog.Domain.Enumerations;
using DVar.BLog.Domain.ValueObjects;

namespace DVar.BLog.Domain.Entities;

public class Feedback : Entity
{
    public FeedbackType FeedbackType { get; set; }
    public string MessageTitle { get; set; } = string.Empty;
    public string MessageBody { get; set; } = string.Empty;
    public DateTime FeedbackCratedDateTime { get; set; } = DateTime.UtcNow;
    public FullName UserFullName { get; set; } = null!;
    public string UserEmail { get; set; } = string.Empty;
}