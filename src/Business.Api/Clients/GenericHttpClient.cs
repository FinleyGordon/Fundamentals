namespace Business.Api.Clients;

public class GenericHttpClient
{
    private readonly HttpClient _httpClient;

    public GenericHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<String?> GetResult()
    {
        var response = await _httpClient.GetAsync("api/");
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }

        return null;
    }
}