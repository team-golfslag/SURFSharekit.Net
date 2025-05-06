// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitWebhookPayloadData
{
    /// <summary>
    /// A unique UuidV4 identifier to identify the object.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The type of object, for now it can only contain the value "RepoItem".
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
