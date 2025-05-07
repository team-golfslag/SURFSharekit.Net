using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models
{
    public class SURFSharekitCost
    {
        [JsonPropertyName("source")] public string? Source { get; set; }

        [JsonPropertyName("value")] public string? Value { get; set; }
    }
}
