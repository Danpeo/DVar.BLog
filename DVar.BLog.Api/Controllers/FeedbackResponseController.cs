using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Infrastructure.Data;
using DVar.BLog.Infrastructure.Emails;
using DVar.BLog.Shared.Requests.Feedbacks;
using Microsoft.AspNetCore.Mvc;

namespace DVar.BLog.Api.Controllers;

[Route("api/v1/[controller]s")]
public class FeedbackResponseController(
    IFeedbackResponseRepository feedbackResponseRepository,
    IFeedbackRepository feedbackRepository,
    IUnitOfWork unitOfWork,
    IEmailService emailService) : Controller
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateFeedbackResponseRequest? request)
    {
        if (request is null)
            return BadRequest();

        var feedback = await feedbackRepository.GetAsync(request.FeedbackId);

        if (feedback is null)
            return BadRequest();

        var feedbackResponse = new FeedbackResponse
        {
            Feedback = feedback,
            Response = request.Response,
        };

        feedbackResponseRepository.Create(feedbackResponse);
        if (await unitOfWork.CompleteAsync())
        {
            await emailService.SendEmailAsync($"{feedback.UserEmail}", $"[{feedback.MessageTitle}]",
                $"{request.Response}");
            return Ok(feedbackResponse.Id);
        }

        return BadRequest();
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Feedback>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListAsync([FromQuery] PaginationParams paginationParams)
    {
        var feedbackResponses = await feedbackResponseRepository.ListAsync(paginationParams);
        return Ok(feedbackResponses);
    }
}