using DVar.BLog.Domain.Entities;

namespace DVar.BLog.Shared.Responses;

public class FeedbackResponseResponse
{
    public Guid Id { get; set; }
    public Feedback Feedback { get; set; } = new();
    public string Response { get; set; } = string.Empty;
    public DateTime ResponseDateTime { get; set; } = DateTime.UtcNow;
}