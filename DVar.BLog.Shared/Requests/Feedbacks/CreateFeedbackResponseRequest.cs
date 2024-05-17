namespace DVar.BLog.Shared.Requests.Feedbacks;

public class CreateFeedbackResponseRequest
{
    public Guid FeedbackId { get; set; }
    public string Response { get; set; } = string.Empty;
}