using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;

namespace DVar.BLog.Domain.RepositoryAbstractions;

public interface IFeedbackResponseRepository
{
    void Create(FeedbackResponse response);
    Task<IEnumerable<FeedbackResponse>> ListAsync(PaginationParams paginationParams);
}