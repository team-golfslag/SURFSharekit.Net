// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitCost
{
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}
