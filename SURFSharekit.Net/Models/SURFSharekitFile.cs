using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitFile
{
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    [JsonPropertyName("accessRight")]
    public string? AccessRight { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("resourceMimeType")]
    public string? ResourceMimeType { get; set; }

    [JsonPropertyName("usageRight")]
    public string? UsageRight { get; set; }

    [JsonPropertyName("important")]
    public string? Important { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }
}
