using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitAuthor
{
    [JsonPropertyName("person")]
    public SURFSharekitPerson SURFSharekitPerson { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
}
