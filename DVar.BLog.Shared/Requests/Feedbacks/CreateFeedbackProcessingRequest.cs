namespace DVar.BLog.Shared.Requests.Feedbacks;

public class CreateFeedbackProcessingRequest
{
    public Guid FeedbackId { get; set; }
    public DateTime DueDateTime { get; set; } = DateTime.UtcNow;
}