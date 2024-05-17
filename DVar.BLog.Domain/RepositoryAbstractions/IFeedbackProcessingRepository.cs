using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;

namespace DVar.BLog.Domain.RepositoryAbstractions;

public interface IFeedbackProcessingRepository
{
    void Create(FeedbackProcessing processing);
    Task<IEnumerable<FeedbackProcessing>> ListAsync(PaginationParams paginationParams);
}