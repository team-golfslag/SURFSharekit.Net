// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitRepoItemLinks
{
    [JsonPropertyName("first")]
    public string? First { get; set; }

    [JsonPropertyName("self")]
    public string? Self { get; set; }

    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("last")]
    public string? Last { get; set; }
}
