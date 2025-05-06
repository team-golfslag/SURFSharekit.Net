// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitAuthor
{
    [JsonPropertyName("person")]
    public SURFSharekitPerson? SURFSharekitPerson { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }
}
