
public class DeezerService
{
    private readonly HttpClient _httpClient;

    public DeezerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<DeezerResponse> SearchTracksAsync(string query)
    {
        var response = await _httpClient.GetFromJsonAsync<DeezerResponse>($"https://api.deezer.com/search/track?q={query}");
        return response;
    }
}