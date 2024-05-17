using DVar.BLog.Domain.Entities;
using DVar.BLog.Shared.Requests.Feedbacks;
using DVar.BLog.Shared.Responses;

namespace DVar.Blog.App.Api;

public class FeedbackResponseApi(HttpClient httpClient)
{
    public async Task CreateFeedbackResponseAsync(CreateFeedbackResponseRequest request)
    {
        await Http.PostAsync(request, "api/v1/FeedbackResponses", httpClient);
    }
    
    public async Task<List<FeedbackResponseResponse>?> ListFeedbackResponsesAsync(
        int pageNumber = 0,
        int pageSize = 0
    )
    {
        var requestUri = $"api/v1/FeedbackResponses/?PageNumber={pageNumber}&PageSize={pageSize}";
        return await Http.ListAsync<FeedbackResponseResponse>(requestUri, httpClient);
    }
}