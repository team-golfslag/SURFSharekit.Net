using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitMeta
{
    [JsonPropertyName("totalCount")]
    public int? TotalCount { get; set; }
}
