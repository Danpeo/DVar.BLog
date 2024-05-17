using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DVar.BLog.Infrastructure.Repositories;

public class FeedbackProcessingRepository(AppDbContext db) : IFeedbackProcessingRepository
{
    public void Create(FeedbackProcessing processing) => db.FeedbackProcessings.Add(processing);

    public async Task<IEnumerable<FeedbackProcessing>> ListAsync(PaginationParams paginationParams)
    {
        var processings = await GetFeedbackResponseData()
            .ToListAsync();
        return processings.Paginate(paginationParams);
    }

    private IOrderedQueryable<FeedbackProcessing> GetFeedbackResponseData()
    {
        return db.FeedbackProcessings
            .Include(fr => fr.Feedback)
            .OrderBy(fr => fr.DueDateTime);
    }
}