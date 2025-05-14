using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitRepoItem
{
    [JsonPropertyName("attributes")]
    public SURFSharekitAttributes? Attributes { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
