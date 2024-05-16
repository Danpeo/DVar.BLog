namespace DVar.BLog.Infrastructure.Emails;

public interface IEmailService
{
    Task SendEmailAsync(string emailTo, string subject, string body);
}