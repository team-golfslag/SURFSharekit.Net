// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models.WebhooksByDocumentation;

/// <summary>
/// <para>
/// Webhooks in our system provide real-time notifications when RepoItems are updated, created or deleted.
/// This allows external applications or services to stay synchronized with the latest changes in our repository.
/// Webhooks are triggered for the following events: creation, update or deletion of a RepoItem.
/// Upon failure webhooks are retransmitted once.
/// </para>
/// <para>
/// Webhooks are enabled and configured per channel.
/// Please contact a WORKSAdmin to enable webhooks for a specific channel and configuring the callback url.
/// </para>
/// </summary>
public class SURFSharekitWebhookPayload
{
    /// <summary>
    /// A unique UuidV4 identifier to identify this webhook.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Type of webhook, the following types are supported: "Create", "Update" and "Delete".
    /// </summary>
    [JsonPropertyName("type")]
    public SURFSharekitWebhookPayloadType Type { get; set; }

    /// <summary>
    /// Timestamp indicating the time at which the webhook was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Contains a JSON object with information about the object for which the webhook was created.
    /// </summary>
    [JsonPropertyName("data")]
    public SURFSharekitWebhookPayloadData? Data { get; set; }
}
