// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitLink
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("accessRight")]
    public string? AccessRight { get; set; }

    [JsonPropertyName("urlName")]
    public string? UrlName { get; set; }
}
