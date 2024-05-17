using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Infrastructure.Data;
using DVar.BLog.Shared.Requests.Feedbacks;
using Microsoft.AspNetCore.Mvc;

namespace DVar.BLog.Api.Controllers;

[Route("api/v1/[controller]s")]
public class FeedbackProcessingController(
    IFeedbackProcessingRepository feedbackProcessingRepository,
    IFeedbackRepository feedbackRepository,
    IUnitOfWork unitOfWork) : Controller
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreateFeedbackProcessingRequest? request)
    {
        if (request is null || !ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var feedback = await feedbackRepository.GetAsync(request.FeedbackId);

        if (feedback is null)
            return BadRequest();

        var feedbackProcessing = new FeedbackProcessing()
        {
            Feedback = feedback,
            DueDateTime = request.DueDateTime,
        };

        feedbackProcessingRepository.Create(feedbackProcessing);
        if (await unitOfWork.CompleteAsync())
        {
            return Ok(feedbackProcessing.Id);
        }

        return BadRequest();
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Feedback>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListAsync([FromQuery] PaginationParams paginationParams)
    {
        var feedbackProcessings = await feedbackProcessingRepository.ListAsync(paginationParams);
        if (feedbackProcessings.Any())
        {
            return Ok(feedbackProcessings);
        }

        return NotFound();
    }
}