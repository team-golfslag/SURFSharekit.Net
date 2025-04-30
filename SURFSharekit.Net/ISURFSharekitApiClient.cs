// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using SURFSharekit.Net.Models;

namespace SURFSharekit.Net;

public interface ISURFSharekitApiClient
{
    /// <summary>
    /// Sets the bearer token for all subsequent requests.
    /// Call this before calling other methods if authentication is required.
    /// </summary>
    void SetBearerToken(string bearerToken);
    
    /// <summary>
    /// Get all <see cref="SURFSharekitRepoItem"/>s accessible to the token
    /// </summary>
    Task<List<SURFSharekitRepoItem>?> GetAllRepoItems();
    
    /// <summary>
    /// Get a specific <see cref="SURFSharekitRepoItem"/>
    /// </summary>
    /// <param name="id"></param>
    Task<SURFSharekitRepoItem?> GetRepoItemById(string id);
}