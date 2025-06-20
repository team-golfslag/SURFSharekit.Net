// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitRepoItemsResult
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("meta")]
    public SURFSharekitMeta? Meta { get; set; }

    [JsonPropertyName("filters")]
    public List<string> Filters { get; set; } = [];

    [JsonPropertyName("links")]
    public SURFSharekitRepoItemLinks? Links { get; set; }

    [JsonPropertyName("data")]
    public List<SURFSharekitRepoItem> Data { get; set; } = [];
}
