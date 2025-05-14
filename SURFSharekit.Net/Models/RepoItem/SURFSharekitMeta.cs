using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitMeta
{
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}
