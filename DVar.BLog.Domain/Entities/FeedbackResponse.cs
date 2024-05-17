using Danilvar.Entity;

namespace DVar.BLog.Domain.Entities;

public class FeedbackResponse : Entity
{
    public Feedback Feedback { get; set; } = new();
    public string Response { get; set; } = string.Empty;
    public DateTime ResponseDateTime { get; set; } = DateTime.UtcNow;
}