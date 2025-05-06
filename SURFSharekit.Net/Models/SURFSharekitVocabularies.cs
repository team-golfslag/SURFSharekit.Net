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