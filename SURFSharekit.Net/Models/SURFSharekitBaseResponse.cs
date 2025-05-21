// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;
using SURFSharekit.Net.Models.RepoItem;
using SURFSharekit.Net.Models.Webhooks;

namespace SURFSharekit.Net.Models;

public class SURFSharekitBaseResponse
{
    /// <summary>
    /// Type is object, because it could either be a <see cref="SURFSharekitWebhookCreate"/>,
    /// <see cref="SURFSharekitRepoItem"/> (both <see cref="SURFSharekitAttributes"/>) or
    /// <see cref="SURFSharekitWebhookDelete"/> (an empty list)
    /// </summary>
    [JsonPropertyName("attributes")]
    public object? Attributes { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
