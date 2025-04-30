using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitCost
{
    [JsonPropertyName("source")]
    public object Source { get; set; }

    [JsonPropertyName("value")]
    public object Value { get; set; }
}
