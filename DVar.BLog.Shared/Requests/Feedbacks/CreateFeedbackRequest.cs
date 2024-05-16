using DVar.BLog.Domain.Enumerations;
using DVar.BLog.Domain.ValueObjects;

namespace DVar.BLog.Shared.Requests.Feedbacks;

public class CreateFeedbackRequest
{
    public FeedbackType FeedbackType { get; set; }
    public string MessageTitle { get; set; } = string.Empty;
    public string MessageBody { get; set; } = string.Empty;
    public FullName UserFullName { get; set; } = null!;
    public string UserEmail { get; set; } = string.Empty;
}