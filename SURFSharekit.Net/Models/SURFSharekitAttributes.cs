using System.Text.Json.Serialization;

namespace SURFSharekit.Net.Models;

public class SURFSharekitAttributes
{
    [JsonPropertyName("owner")]
    public SURFSharekitOwner SURFSharekitOwner { get; set; }

    [JsonPropertyName("consortium")]
    public string Consortium { get; set; }

    [JsonPropertyName("typicalAgeRange")]
    public object TypicalAgeRange { get; set; }

    [JsonPropertyName("cost")]
    public SURFSharekitCost SURFSharekitCost { get; set; }

    [JsonPropertyName("urn:nbn")]
    public object UrnNbn { get; set; }

    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("subtitle")]
    public object Subtitle { get; set; }

    [JsonPropertyName("publishers")]
    public List<string> Publishers { get; set; }

    [JsonPropertyName("publishedAt")]
    public string PublishedAt { get; set; }

    [JsonPropertyName("place")]
    public object Place { get; set; }

    [JsonPropertyName("abstract")]
    public string Abstract { get; set; }

    [JsonPropertyName("keywords")]
    public List<string> Keywords { get; set; }

    [JsonPropertyName("numOfPages")]
    public object NumOfPages { get; set; }

    [JsonPropertyName("links")]
    public List<SURFSharekitLink> Links { get; set; }

    [JsonPropertyName("authors")]
    public List<SURFSharekitAuthor> Authors { get; set; }

    [JsonPropertyName("files")]
    public List<SURFSharekitFile> Files { get; set; }

    [JsonPropertyName("institutes")]
    public List<SURFSharekitInstitute> Institutes { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("themesResearchObject")]
    public object ThemesResearchObject { get; set; }

    [JsonPropertyName("termsOfUse")]
    public string TermsOfUse { get; set; }

    [JsonPropertyName("educationalLevels")]
    public List<SURFSharekitEducationalLevel> EducationalLevels { get; set; }

    [JsonPropertyName("typeResearchObject")]
    public object TypeResearchObject { get; set; }

    [JsonPropertyName("typesLearningMaterial")]
    public List<string> TypesLearningMaterial { get; set; }

    [JsonPropertyName("themesLearningMaterial")]
    public List<string> ThemesLearningMaterial { get; set; }

    [JsonPropertyName("hasParts")]
    public List<string> HasParts { get; set; }

    [JsonPropertyName("partOf")]
    public List<string> PartOf { get; set; }

    [JsonPropertyName("technicalFormat")]
    public string TechnicalFormat { get; set; }

    [JsonPropertyName("vocabularies")]
    public SURFSharekitVocabularies SURFSharekitVocabularies { get; set; }

    [JsonPropertyName("aggregationlevel")]
    public string Aggregationlevel { get; set; }

    [JsonPropertyName("intendedUser")]
    public string IntendedUser { get; set; }

    [JsonPropertyName("doi")]
    public string Doi { get; set; }

    [JsonPropertyName("availability")]
    public object Availability { get; set; }

    [JsonPropertyName("handle")]
    public object Handle { get; set; }

    [JsonPropertyName("publishedIn")]
    public SURFSharekitPublishedIn SURFSharekitPublishedIn { get; set; }

    [JsonPropertyName("conference")]
    public object Conference { get; set; }
}
