using DVar.BLog.Domain.Entities;
using DVar.BLog.Domain.Params;
using DVar.BLog.Domain.ValueObjects;

namespace DVar.BLog.Domain.RepositoryAbstractions;

public interface IFeedbackRepository
{
    void Create(Feedback feedback);
    Task<Feedback?> GetAsync(Guid id);
    Task<IEnumerable<Feedback>> ListAsync(PaginationParams paginationParams);
}