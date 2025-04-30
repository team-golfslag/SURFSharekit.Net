using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitVocabularies
{
    [JsonPropertyName("vocabularyZiezo")]
    public List<Vocabulary> VocabularyZiezo { get; set; }

    [JsonPropertyName("vocabularyDas")]
    public List<Vocabulary> VocabularyDas { get; set; }

    [JsonPropertyName("vocabularyInformationLiteracy")]
    public List<Vocabulary> VocabularyInformationLiteracy { get; set; }

    [JsonPropertyName("vocabularyVerpleegkunde")]
    public List<Vocabulary> VocabularyVerpleegkunde { get; set; }

    [JsonPropertyName("vocabularyVaktherapie")]
    public List<Vocabulary> VocabularyVaktherapie { get; set; }
}

public class Vocabulary
{
    [JsonPropertyName("source")]
    public string Source { get; set; }
    
    [JsonPropertyName("value")]
    public string Value { get; set; }
    
}