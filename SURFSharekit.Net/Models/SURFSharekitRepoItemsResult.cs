using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models
{
    public class SURFSharekitRepoItemsResult
    {
        [JsonPropertyName("name")] public string? Name { get; set; }

        [JsonPropertyName("meta")] public SURFSharekitMeta? Meta { get; set; }

        [JsonPropertyName("filters")] public List<string> Filters { get; set; } = [];

        [JsonPropertyName("links")] public SURFSharekitRepoItemLinks? Links { get; set; }

        [JsonPropertyName("data")] public List<SURFSharekitRepoItem> Data { get; set; } = [];
    }
}
