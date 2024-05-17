using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DVar.BLog.Infrastructure.Repositories;

public class FeedbackResponseRepository(AppDbContext db) : IFeedbackResponseRepository
{
    public void Create(FeedbackResponse response) => db.FeedbackResponses.Add(response);

    public async Task<IEnumerable<FeedbackResponse>> ListAsync(PaginationParams paginationParams)
    {
        var feedbackResponses = await GetFeedbackResponseData()
            .ToListAsync();
        return feedbackResponses.Paginate(paginationParams);
    }

    private IOrderedQueryable<FeedbackResponse> GetFeedbackResponseData()
    {
        return db.FeedbackResponses
            .Include(fr => fr.Feedback)
            .OrderBy(fr => fr.ResponseDateTime);
    }
}