// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SURFSharekit.Net.Models;
using SURFSharekit.Net.Models.RepoItem;
using SURFSharekit.Net.Models.Webhooks;

namespace SURFSharekit.Net.Tests;

public class SURFSharekitBaseWebhookDtoTests
{
    [Fact]
    public void Deserialize_ShouldReturnRepoItem()
    {
        string json =
            """
            {
              "attributes": {
                "owner": {
                  "id": "eb98be07-f863-4815-805a-ad7f6cdea765",
                  "name": "Zooma University",
                  "type": "organisation"
                },
                "mboDomain": [],
                "mboDiscipline": [],
                "typicalAgeRange": {
                  "string": null
                },
                "cost": {
                  "source": null,
                  "value": null
                },
                "urn:nbn": null,
                "modifiedAt": "2025-03-21T13:14:32Z",
                "title": "Webhook test - titel",
                "subtitle": "Webhook test - ondertitel",
                "publishers": [
                  "Zooma University"
                ],
                "publishedAt": "2025",
                "place": null,
                "abstract": "Webhook test - samenvatting",
                "keywords": [
                  "Webhook test"
                ],
                "numOfPages": null,
                "links": [
                  {
                    "url": "https://acc.surfsharekit.nl/link/c8a71cc4-8e0a-45ec-84fd-b27511bca116",
                    "accessRight": "openaccess",
                    "urlName": "Zooma",
                    "important": "1"
                  }
                ],
                "authors": [
                  {
                    "person": {
                      "id": "8b48a18f-1726-4269-9a7b-4279c967f35b",
                      "name": "Lucas Slim",
                      "email": "lslim@live.nl",
                      "dai": null,
                      "orcid": null,
                      "isni": null
                    },
                    "role": null,
                    "external": null,
                    "alias": null
                  }
                ],
                "files": [
                  {
                    "fileName": "DummyFile",
                    "accessRight": "openaccess",
                    "url": "https://acc.surfsharekit.nl/objectstore/1a9bd201-897d-4852-8bb2-59c9364d0d3d",
                    "resourceMimeType": "application/pdf",
                    "usageRight": "pdm-10",
                    "important": "1",
                    "eTag": null
                  }
                ],
                "institutes": null,
                "language": "nl",
                "themesResearchObject": null,
                "termsOfUse": null,
                "educationalLevels": [
                  {
                    "source": "http://purl.edustandaard.nl/vdex_context_czp_20060628.xml",
                    "value": "HBO"
                  }
                ],
                "typeResearchObject": null,
                "typesLearningMaterial": [],
                "themesLearningMaterial": [
                  "onderwijs_opvoeding"
                ],
                "hasParts": [],
                "partOf": [],
                "technicalFormat": null,
                "vocabularies": {
                  "vocabularyZiezo": [],
                  "vocabularyDas": [],
                  "vocabularyInformationLiteracy": [],
                  "vocabularyVerpleegkunde": [],
                  "vocabularyVaktherapie": []
                },
                "aggregationlevel": "3",
                "intendedUser": "author",
                "raid": null,
                "siaFileNum": null,
                "doi": null,
                "handle": null,
                "availability": null,
                "publishedIn": {
                  "title": null,
                  "publisherDocument": null,
                  "placeOfPublication": null,
                  "year": null,
                  "issue": null,
                  "edition": null,
                  "issn": null,
                  "isbn": null,
                  "pageStart": null,
                  "pageEnd": null
                },
                "conference": null
              },
              "type": "repoItem",
              "id": "69ed4ccb-1825-48d4-8c6f-53f8e4b78f88"
            }
            """;

        // Act
        SURFSharekitRepoItem? result = JsonConvert.DeserializeObject<SURFSharekitRepoItem>(json);

        Assert.NotNull(result);
        Assert.Equal("69ed4ccb-1825-48d4-8c6f-53f8e4b78f88", result.Id);
    }

    [Fact]
    public void Deserialize_ShouldReturnWebhookCreateDTO()
    {
        string json =
            """
            {
              "attributes": {
                "owner": {
                  "id": "eb98be07-f863-4815-805a-ad7f6cdea765",
                  "name": "Zooma University",
                  "type": "organisation"
                },
                "mboDomain": [],
                "mboDiscipline": [],
                "typicalAgeRange": {
                  "string": null
                },
                "cost": {
                  "source": null,
                  "value": null
                },
                "urn:nbn": null,
                "modifiedAt": "2025-03-21T13:14:32Z",
                "title": "Webhook test - titel",
                "subtitle": "Webhook test - ondertitel",
                "publishers": [
                  "Zooma University"
                ],
                "publishedAt": "2025",
                "place": null,
                "abstract": "Webhook test - samenvatting",
                "keywords": [
                  "Webhook test"
                ],
                "numOfPages": null,
                "links": [
                  {
                    "url": "https://acc.surfsharekit.nl/link/c8a71cc4-8e0a-45ec-84fd-b27511bca116",
                    "accessRight": "openaccess",
                    "urlName": "Zooma",
                    "important": "1"
                  }
                ],
                "authors": [
                  {
                    "person": {
                      "id": "8b48a18f-1726-4269-9a7b-4279c967f35b",
                      "name": "Lucas Slim",
                      "email": "lslim@live.nl",
                      "dai": null,
                      "orcid": null,
                      "isni": null
                    },
                    "role": null,
                    "external": null,
                    "alias": null
                  }
                ],
                "files": [
                  {
                    "fileName": "DummyFile",
                    "accessRight": "openaccess",
                    "url": "https://acc.surfsharekit.nl/objectstore/1a9bd201-897d-4852-8bb2-59c9364d0d3d",
                    "resourceMimeType": "application/pdf",
                    "usageRight": "pdm-10",
                    "important": "1",
                    "eTag": null
                  }
                ],
                "institutes": null,
                "language": "nl",
                "themesResearchObject": null,
                "termsOfUse": null,
                "educationalLevels": [
                  {
                    "source": "http://purl.edustandaard.nl/vdex_context_czp_20060628.xml",
                    "value": "HBO"
                  }
                ],
                "typeResearchObject": null,
                "typesLearningMaterial": [],
                "themesLearningMaterial": [
                  "onderwijs_opvoeding"
                ],
                "hasParts": [],
                "partOf": [],
                "technicalFormat": null,
                "vocabularies": {
                  "vocabularyZiezo": [],
                  "vocabularyDas": [],
                  "vocabularyInformationLiteracy": [],
                  "vocabularyVerpleegkunde": [],
                  "vocabularyVaktherapie": []
                },
                "aggregationlevel": "3",
                "intendedUser": "author",
                "raid": null,
                "siaFileNum": null,
                "doi": null,
                "handle": null,
                "availability": null,
                "publishedIn": {
                  "title": null,
                  "publisherDocument": null,
                  "placeOfPublication": null,
                  "year": null,
                  "issue": null,
                  "edition": null,
                  "issn": null,
                  "isbn": null,
                  "pageStart": null,
                  "pageEnd": null
                },
                "conference": null
              },
              "type": "repoItem",
              "id": "69ed4ccb-1825-48d4-8c6f-53f8e4b78f88"
            }
            """;

        // Act
        SURFSharekitWebhookBaseDTO dto = SURFSharekitWebhookBaseDTO.Deserialize(json);

        Assert.IsType<SURFSharekitWebhookCreateDTO>(dto);
        Assert.Equal("69ed4ccb-1825-48d4-8c6f-53f8e4b78f88", (dto as SURFSharekitWebhookCreateDTO)!.Id);
    }
    
    [Fact]
    public void Deserialize_ShouldReturnWebhookDeleteDTO()
    {
        string json =
            """
            {
              "attributes": [],
              "type": "repoItem",
              "meta": {
                "status": "deleted",
                "deletedAt": "2025-03-21T15:00:56Z"
              },
              "id": "69ed4ccb-1825-48d4-8c6f-53f8e4b78f88"
            }
            """;

        // Act
        SURFSharekitWebhookBaseDTO dto = SURFSharekitWebhookBaseDTO.Deserialize(json);

        Assert.IsType<SURFSharekitWebhookDeleteDTO>(dto);
        Assert.Equal("69ed4ccb-1825-48d4-8c6f-53f8e4b78f88", (dto as SURFSharekitWebhookDeleteDTO)!.Id);
    }
}
