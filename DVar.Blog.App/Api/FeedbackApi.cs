using DVar.BLog.Domain.Entities;
using DVar.BLog.Shared.Requests.Feedbacks;

namespace DVar.Blog.App.Api;

public class FeedbackApi(HttpClient httpClient)
{
    public async Task CreateFeedbackAsync(CreateFeedbackRequest request)
    {
        await Http.PostAsync(request, "api/v1/Feedbacks", httpClient);
    }
    
    public async Task<List<Feedback>?> ListFeedbacksAsync(
        int pageNumber = 0,
        int pageSize = 0
    )
    {
        var requestUri = $"api/v1/Feedbacks/?PageNumber={pageNumber}&PageSize={pageSize}";
        return await Http.ListAsync<Feedback>(requestUri, httpClient);
    }
}