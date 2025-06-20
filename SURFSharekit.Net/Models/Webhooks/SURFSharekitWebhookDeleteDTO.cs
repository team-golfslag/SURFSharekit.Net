// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;
using SURFSharekit.Net.Models.RepoItem;

namespace SURFSharekit.Net.Models.Webhooks;

public class SURFSharekitWebhookDeleteDTO : SURFSharekitWebhookBaseDTO
{
    [JsonPropertyName("meta")]
    public SURFSharekitWebhookDeleteMeta? Meta { get; set; }

    [JsonPropertyName("attributes")]
    public List<object> Attributes { get; set; } = [];

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}