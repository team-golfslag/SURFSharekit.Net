using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitOwner
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}
