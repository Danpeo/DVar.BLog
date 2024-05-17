using DVar.BLog.Domain.Entities;

namespace DVar.BLog.Shared.Responses;

public class FeedbackProcessingResponse
{
    public Guid Id { get; set; }
    public Feedback Feedback { get; set; } = new();
    public DateTime DueDateTime { get; set; } = DateTime.UtcNow;
}