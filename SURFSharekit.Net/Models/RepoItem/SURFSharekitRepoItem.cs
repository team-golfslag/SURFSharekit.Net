using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.RepoItem;

public class SURFSharekitRepoItem : SURFSharekitBaseResponse
{
    [JsonPropertyName("attributes")]
    public new SURFSharekitAttributes? Attributes { get; set; }
}
