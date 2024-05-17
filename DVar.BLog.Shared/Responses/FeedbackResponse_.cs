using DVar.BLog.Domain.Enumerations;
using DVar.BLog.Domain.ValueObjects;

namespace DVar.BLog.Shared.Responses;

public class FeedbackResponse_
{
    public Guid Id { get; set; }
    public FeedbackType FeedbackType { get; set; }
    public string MessageTitle { get; set; } = string.Empty;
    public string MessageBody { get; set; } = string.Empty;
    public DateTime FeedbackCratedDateTime { get; set; } = DateTime.UtcNow;
    public FullName UserFullName { get; set; } = null!;
    public string UserEmail { get; set; } = string.Empty;
    
    public string GetFeedbackTypeByText()
    {
        return FeedbackType switch
        {
            FeedbackType.Proposal => "Предложение",
            FeedbackType.BugReport => "Ошибка",
            _ => "Неизвестно"
        };
    }
}