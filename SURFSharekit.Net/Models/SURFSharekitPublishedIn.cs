using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitPublishedIn
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("publisherDocument")]
    public string PublisherDocument { get; set; }

    [JsonPropertyName("placeOfPublication")]
    public string PlaceOfPublication { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [JsonPropertyName("issue")]
    public string Issue { get; set; }

    [JsonPropertyName("edition")]
    public string Edition { get; set; }

    [JsonPropertyName("issn")]
    public string Issn { get; set; }

    [JsonPropertyName("isbn")]
    public string Isbn { get; set; }

    [JsonPropertyName("pageStart")]
    public int? PageStart { get; set; }

    [JsonPropertyName("pageEnd")]
    public int? PageEnd { get; set; }
}
