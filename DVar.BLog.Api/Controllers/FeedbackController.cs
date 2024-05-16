using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Infrastructure.Data;
using DVar.BLog.Infrastructure.Emails;
using DVar.BLog.Shared.Requests.Feedbacks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DVar.BLog.Api.Controllers;

[Route("api/v1/[controller]s")]
public class FeedbackController(
    IFeedbackRepository feedbackRepository,
    IUnitOfWork unitOfWork,
    IEmailService emailService,
    IOptions<AdminParams> adminParamsOptions) : Controller
{

    private readonly AdminParams _adminParams = adminParamsOptions.Value;
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateFeedbackRequest? request)
    {
        if (request is null)
            return BadRequest();

        var feedback = new Feedback()
        {
            FeedbackType = request.FeedbackType,
            MessageTitle = request.MessageTitle,
            MessageBody = request.MessageBody, UserEmail = request.UserEmail,
            UserFullName = request.UserFullName
        };

        feedbackRepository.Create(feedback);
        if (await unitOfWork.CompleteAsync())
        {
            await emailService.SendEmailAsync($"{_adminParams.AdminEmail}", $"[{request.MessageTitle}]",
                $"{request.MessageBody}");
            return Ok(feedback.Id);
        }

        return BadRequest();
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Feedback>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListAsync([FromQuery] PaginationParams paginationParams)
    {
        var feedbacks = await feedbackRepository.ListAsync(paginationParams);
        return Ok(feedbacks);
    }
}