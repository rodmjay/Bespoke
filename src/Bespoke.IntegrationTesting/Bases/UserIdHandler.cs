namespace Bespoke.IntegrationTesting.Bases;

public class UserIdHandler : DelegatingHandler
{
    private readonly Func<int> _getUserId;

    public UserIdHandler(Func<int> getUserId)
    {
        _getUserId = getUserId ?? throw new ArgumentNullException(nameof(getUserId));
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        // Dynamically add the header based on UserId
        var userId = _getUserId();
        request.Headers.Add("X-User-Id", userId.ToString());

        return await base.SendAsync(request, cancellationToken);
    }
}