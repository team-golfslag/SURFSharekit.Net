// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitVocabularies
{
    [JsonPropertyName("vocabularyZiezo")]
    public List<SURFSharekitVocabulary> VocabularyZiezo { get; set; } = [];

    [JsonPropertyName("vocabularyDas")]
    public List<SURFSharekitVocabulary> VocabularyDas { get; set; } = [];

    [JsonPropertyName("vocabularyInformationLiteracy")]
    public List<SURFSharekitVocabulary> VocabularyInformationLiteracy { get; set; } = [];

    [JsonPropertyName("vocabularyVerpleegkunde")]
    public List<SURFSharekitVocabulary> VocabularyVerpleegkunde { get; set; } = [];

    [JsonPropertyName("vocabularyVaktherapie")]
    public List<SURFSharekitVocabulary> VocabularyVaktherapie { get; set; } = [];
}
