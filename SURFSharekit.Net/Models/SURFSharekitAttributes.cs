// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitAttributes
{
    [JsonPropertyName("owner")]
    public SURFSharekitOwner? SURFSharekitOwner { get; set; }

    [JsonPropertyName("consortium")]
    public string? Consortium { get; set; }

    [JsonPropertyName("typicalAgeRange")]
    public string? TypicalAgeRange { get; set; }

    [JsonPropertyName("cost")]
    public SURFSharekitCost? SURFSharekitCost { get; set; }

    [JsonPropertyName("urn:nbn")]
    public string? UrnNbn { get; set; }

    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("subtitle")]
    public string? Subtitle { get; set; }

    [JsonPropertyName("publishers")]
    public List<string> Publishers { get; set; } = [];

    [JsonPropertyName("publishedAt")]
    public string? PublishedAt { get; set; }

    [JsonPropertyName("place")]
    public string? Place { get; set; }

    [JsonPropertyName("abstract")]
    public string? Abstract { get; set; }

    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; } = [];

    [JsonPropertyName("numOfPages")]
    public int? NumOfPages { get; set; }

    [JsonPropertyName("links")]
    public List<SURFSharekitLink> Links { get; set; } = [];

    [JsonPropertyName("authors")]
    public List<SURFSharekitAuthor> Authors { get; set; } = [];

    [JsonPropertyName("files")]
    public List<SURFSharekitFile> Files { get; set; } = [];

    [JsonPropertyName("institutes")]
    public List<SURFSharekitInstitute> Institutes { get; set; } = [];

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("themesResearchObject")]
    public string? ThemesResearchObject { get; set; }

    [JsonPropertyName("termsOfUse")]
    public string? TermsOfUse { get; set; }

    [JsonPropertyName("educationalLevels")]
    public List<SURFSharekitEducationalLevel> EducationalLevels { get; set; } = [];

    [JsonPropertyName("typeResearchObject")]
    public string? TypeResearchObject { get; set; }

    [JsonPropertyName("typesLearningMaterial")]
    public List<string> TypesLearningMaterial { get; set; } = [];

    [JsonPropertyName("themesLearningMaterial")]
    public List<string> ThemesLearningMaterial { get; set; } = [];

    [JsonPropertyName("hasParts")]
    public List<string> HasParts { get; set; } = [];

    [JsonPropertyName("partOf")]
    public List<string> PartOf { get; set; } = [];

    [JsonPropertyName("technicalFormat")]
    public string? TechnicalFormat { get; set; }

    [JsonPropertyName("vocabularies")]
    public SURFSharekitVocabularies? SURFSharekitVocabularies { get; set; }

    [JsonPropertyName("aggregationlevel")]
    public string? AggregationLevel { get; set; }

    [JsonPropertyName("intendedUser")]
    public string? IntendedUser { get; set; }

    [JsonPropertyName("doi")]
    public string? Doi { get; set; }

    [JsonPropertyName("availability")]
    public string? Availability { get; set; }

    [JsonPropertyName("handle")]
    public string? Handle { get; set; }

    [JsonPropertyName("publishedIn")]
    public SURFSharekitPublishedIn? SURFSharekitPublishedIn { get; set; }

    [JsonPropertyName("conference")]
    public string? Conference { get; set; }
}
