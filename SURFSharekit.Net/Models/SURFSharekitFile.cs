using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitFile
{
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    [JsonPropertyName("accessRight")]
    public string? AccessRight { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("resourceMimeType")]
    public string? ResourceMimeType { get; set; }
}
