using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitTypicalAgeRange
{
    [JsonPropertyName("string")]
    public string? String { get; set; }
}
