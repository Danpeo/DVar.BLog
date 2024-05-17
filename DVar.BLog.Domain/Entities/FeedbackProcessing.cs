using Danilvar.Entity;

namespace DVar.BLog.Domain.Entities;

public class FeedbackProcessing : Entity
{
    public Feedback Feedback { get; set; } = new();
    public DateTime DueDateTime { get; set; } = DateTime.UtcNow;
}