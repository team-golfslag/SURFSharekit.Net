// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitRepoItemsResult
{
    [JsonPropertyName("meta")]
    public SURFSharekitMeta? SURFSharekitMeta { get; set; }

    [JsonPropertyName("filters")]
    public List<string> Filters { get; set; } = [];

    [JsonPropertyName("links")]
    public SURFSharekitLinks? SURFSharekitLinks { get; set; }

    [JsonPropertyName("data")]
    public List<SURFSharekitRepoItem> Data { get; set; } = [];
}
