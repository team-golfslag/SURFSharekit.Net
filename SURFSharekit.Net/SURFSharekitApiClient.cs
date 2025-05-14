// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Net.Http.Json;
using SURFSharekit.Net.Exceptions;
using SURFSharekit.Net.Models;
using SURFSharekit.Net.Models.RepoItem;

namespace SURFSharekit.Net;

public class SURFSharekitApiClient : ISURFSharekitApiClient
{
    private readonly HttpClient _httpClient;

    /// <summary>
    /// Pass a configured HttpClient (with BaseAddress set) into the constructor.
    /// Example usage:
    /// <code>
    ///   var httpClient = new HttpClient
    ///   {
    ///       BaseAddress = new Uri("https://YOUR-API-ENDPOINT/")
    ///   };
    ///   var client = new SURFSharekitApiClient(httpClient);
    /// </code>
    /// </summary>
    public SURFSharekitApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Sets the bearer token for all subsequent requests.
    /// Call this before calling other methods if authentication is required.
    /// </summary>
    public void SetBearerToken(string bearerToken) =>
        _httpClient.DefaultRequestHeaders.Authorization =
            new("Bearer", bearerToken);

    /// <summary>
    /// Get all <see cref="SURFSharekitRepoItem" />s accessible to the token
    /// </summary>
    public async Task<List<SURFSharekitRepoItem>> GetAllRepoItems()
    {
        HttpResponseMessage response = await _httpClient.GetAsync("repoItems");
        response.EnsureSuccessStatusCode();
        SURFSharekitRepoItemsResult? results = await response.Content.ReadFromJsonAsync<SURFSharekitRepoItemsResult>();
        return results?.Data ?? throw new ResultIsNullException(response.Content.ReadAsStringAsync().Result);
    }

    /// <summary>
    /// Get a specific <see cref="SURFSharekitRepoItem" />
    /// </summary>
    /// <param name="id">The repo </param>
    public async Task<SURFSharekitRepoItem> GetRepoItemById(string id)
    {
        HttpResponseMessage response = await _httpClient.GetAsync($"repoItems/{id}");
        response.EnsureSuccessStatusCode();
        SURFSharekitRepoItem? result = await response.Content.ReadFromJsonAsync<SURFSharekitRepoItem>();

        return result ?? throw new ResultIsNullException(response.Content.ReadAsStringAsync().Result);
    }
}
