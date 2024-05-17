using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.RepositoryAbstractions;
using DVar.BLog.Domain.ValueObjects;
using DVar.BLog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace DVar.BLog.Infrastructure.Repositories;

public class FeedbackRepository(AppDbContext db) : IFeedbackRepository
{
    public void Create(Feedback feedback) => db.Feedbacks.Add(feedback);
    
    public async Task<Feedback?> GetAsync(Guid id)
    {
        Feedback? feedback = await GetFeedbackData()
            .FirstOrDefaultAsync(f => f.Id == id);

        return feedback;
    }

    public async Task<IEnumerable<Feedback>> ListAsync(PaginationParams paginationParams)
    {
        var feedbacks = await GetFeedbackData()
            .OrderBy(f => f.FeedbackCratedDateTime)
            .ToListAsync();
        return feedbacks.Paginate(paginationParams);
    }

    private IIncludableQueryable<Feedback, FullName> GetFeedbackData()
    {
        return db.Feedbacks.Include(f => f.UserFullName);
    }
}