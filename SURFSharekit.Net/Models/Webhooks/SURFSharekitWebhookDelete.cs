// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.WebhookDelete;

public class SURFSharekitWebhookDelete : SURFSharekitRepoItem
{
    [JsonPropertyName("meta")]
    public SURFSharekitWebhookDeleteMeta DeleteMeta { get; set; }
}