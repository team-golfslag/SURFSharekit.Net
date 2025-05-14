using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitVocabulary
{
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
