using DVar.BLog.Shared.Requests.Feedbacks;
using DVar.BLog.Shared.Responses;

namespace DVar.Blog.App.Api;

public class FeedbackProcessingApi(HttpClient httpClient)
{
    public async Task CreateFeedbackProcessingAsync(CreateFeedbackProcessingRequest request)
    {
        await Http.PostAsync(request, "api/v1/FeedbackProcessings", httpClient);
    }
    
    public async Task<List<FeedbackProcessingResponse>?> ListFeedbackProcessingsAsync(
        int pageNumber = 0,
        int pageSize = 0
    )
    {
        var requestUri = $"api/v1/FeedbackProcessings/?PageNumber={pageNumber}&PageSize={pageSize}";
        return await Http.ListAsync<FeedbackProcessingResponse>(requestUri, httpClient);
    }
}