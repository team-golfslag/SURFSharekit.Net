using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitLink
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("accessRight")]
    public string? AccessRight { get; set; }

    [JsonPropertyName("urlName")]
    public string? UrlName { get; set; }

    [JsonPropertyName("important")]
    public string? Important { get; set; }
}
