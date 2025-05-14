using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitAuthor
{
    [JsonPropertyName("person")]
    public SURFSharekitPerson? Person { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("external")]
    public string? External { get; set; }

    [JsonPropertyName("alias")]
    public string? Alias { get; set; }
}
