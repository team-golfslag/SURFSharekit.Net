using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models
{
    public class SURFSharekitPerson
    {
        [JsonPropertyName("id")] public string? Id { get; set; }

        [JsonPropertyName("name")] public string? Name { get; set; }

        [JsonPropertyName("email")] public string? Email { get; set; }

        [JsonPropertyName("dai")] public string? Dai { get; set; }

        [JsonPropertyName("orcid")] public string? Orcid { get; set; }

        [JsonPropertyName("isni")] public string? Isni { get; set; }
    }
}
