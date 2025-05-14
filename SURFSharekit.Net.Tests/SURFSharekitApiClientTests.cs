// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Net;
using SURFSharekit.Net.Exceptions;
using SURFSharekit.Net.Models;
using SURFSharekit.Net.Models.RepoItem;
using SURFSharekit.Net.Tests.Helpers;

namespace SURFSharekit.Net.Tests;

public class SURFSharekitApiClientTests
{
    /// <summary>
    /// When the bearer token to be used to authorize is set,
    /// Then the HTTP client should have an Authorisation header with the bearer token
    /// </summary>
    [Fact]
    public void SetBearerToken_SetsAuthorizationHeader()
    {
        // Arrange
        const string token = "VeryValidToken";
        FakeHttpMessageHandler handler = new("", HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SURFSharekitApiClient client = new(httpClient);

        // Act
        client.SetBearerToken(token);

        // Assert
        Assert.NotNull(httpClient.DefaultRequestHeaders.Authorization);
        Assert.Equal("Bearer", httpClient.DefaultRequestHeaders.Authorization.Scheme);
        Assert.Equal(token, httpClient.DefaultRequestHeaders.Authorization.Parameter);
    }

    /// <summary>
    /// Given a valid <see cref="SURFSharekitApiClient" />,
    /// When GetRepoItemById is called,
    /// Then it should return the <see cref="SURFSharekitRepoItem" /> specified by that id.
    /// </summary>
    [Fact]
    public async Task GetRepoItemById_ReturnsRepoItem()
    {
        // Arrange: Prepare a dummy JSON response for SCIMGroup.
        // dummy json obtained from api specification
        const string json = """
                            {
                              "attributes": {
                                "owner": {
                                  "id": "6949c6f2-517c-4c3e-881f-3d712e0b0640",
                                  "name": "Title institute",
                                  "type": "organisation"
                                },
                                "consortium": "Stimuleringsregeling Open en Online Onderwijs",
                                "typicalAgeRange": null,
                                "cost": {
                                  "source": null,
                                  "value": null
                                },
                                "urn:nbn": null,
                                "modifiedAt": "2023-11-09T11:24:46Z",
                                "title": "Test Title",
                                "subtitle": null,
                                "publishers": [
                                  "University of Harderwijk (TEST) organisatie"
                                ],
                                "publishedAt": "2023",
                                "place": null,
                                "abstract": "test",
                                "keywords": [
                                  "biology"
                                ],
                                "numOfPages": null,
                                "links": [
                                  {
                                    "url": "https://nos.nl",
                                    "accessRight": "openaccess",
                                    "urlName": "NOS"
                                  }
                                ],
                                "authors": [
                                  {
                                    "person": {
                                      "id": "40ebd0f9-72f5-41bc-8816-860cfa3dea45",
                                      "name": "John Doe",
                                      "email": "johndoe@example.org",
                                      "dai": "info:eu-repo/dai/nl/123456785",
                                      "orcid": "0000-0001-5109-3700",
                                      "isni": "ISNI 0000 0001 2149 1740"
                                    },
                                    "role": "Begeleider"
                                  }
                                ],
                                "files": [
                                  {
                                    "fileName": "Test bestand",
                                    "accessRight": "openaccess",
                                    "eTag": "73e3d03235b03bec89514603f4aca86f",
                                    "url": "https://www.location.file.url",
                                    "resourceMimeType": "text/plain"
                                  }
                                ],
                                "institutes": [
                                  {
                                    "name": "Bedrijfscommunicatie",
                                    "type": "discipline",
                                    "id": "ff133bfb-adb1-4dc5-b462-1ee57a14134e"
                                  }
                                ],
                                "language": "de",
                                "themesResearchObject": null,
                                "termsOfUse": "cc-by-40",
                                "educationalLevels": [
                                  {
                                    "source": "http://purl.edustandaard.nl/vdex_context_czp_20060628.xml",
                                    "value": "HBO"
                                  }
                                ],
                                "typeResearchObject": null,
                                "typesLearningMaterial": [
                                  "document"
                                ],
                                "themesLearningMaterial": [
                                  "exact_informatica"
                                ],
                                "hasParts": [
                                  "6c70e6b8-0173-4eff-99ed-1f3218c426dc"
                                ],
                                "partOf": [
                                  "string"
                                ],
                                "technicalFormat": "printable-object",
                                "vocabularies": {
                                  "vocabularyZiezo": [
                                    {
                                      "source": "http://purl.edustandaard.nl/concept/c4fdab5a4-224f-4774-bfe5-71eecf669083",
                                      "value": "Afnemen meetinstrument"
                                    }
                                  ],
                                  "vocabularyDas": [
                                    {
                                      "source": "http://purl.edustandaard.nl/concept/6d78d67c-9d42-4f57-9fa2-b24aabbcf892",
                                      "value": "Chemistry"
                                    }
                                  ],
                                  "vocabularyInformationLiteracy": [
                                    {
                                      "source": "http://purl.edustandaard.nl/concept/9805b56e-4fe8-46b2-9fb0-76ee2026d47b",
                                      "value": "Identificeren van informatiebehoefte"
                                    }
                                  ],
                                  "vocabularyVerpleegkunde": [
                                    {
                                      "source": "http://purl.edustandaard.nl/concept/20c66254-fbf7-4ae6-b4c1-29101adc1376",
                                      "value": "Reflectieve EBP-professional"
                                    }
                                  ],
                                  "vocabularyVaktherapie": [
                                    {
                                      "source": "http://purl.edustandaard.nl/concept/07c606df-bb05-4588-9f59-7f83a48f04e0",
                                      "value": "Kritische houding"
                                    }
                                  ]
                                },
                                "aggregationlevel": "1",
                                "intendedUser": "learner",
                                "doi": "10.80467/8b0f8e7a-4ac8-4401-81ff-59cfec949f48",
                                "availability": null,
                                "handle": null,
                                "publishedIn": {
                                  "title": "Publication Title",
                                  "publisherDocument": "Publisher Document",
                                  "placeOfPublication": "Publication Place",
                                  "year": 2023,
                                  "issue": "Publication Issue",
                                  "edition": "Publication Edition",
                                  "issn": "1234-5678",
                                  "isbn": "978-1-2345-6789-0",
                                  "pageStart": 1,
                                  "pageEnd": 10
                                },
                                "conference": null
                              },
                              "type": "repoItem",
                              "id": "dummy-id"
                            }
                            """;

        FakeHttpMessageHandler handler = new(json, HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SURFSharekitApiClient client = new(httpClient);

        // Act
        SURFSharekitRepoItem? item = await client.GetRepoItemById("dummy-id");

        // Assert
        Assert.NotNull(item);
        Assert.Equal("dummy-id", item.Id);
        Assert.Equal("repoItem", item.Type);
        Assert.NotNull(item.Attributes);
        Assert.Equal("Test Title", item.Attributes.Title);
        Assert.NotEmpty(item.Attributes.Authors);
        Assert.Equal("John Doe", item.Attributes.Authors[0].Person?.Name);
    }

    /// <summary>
    /// Given a valid SCIM API client,
    /// When GetAllRepoItems is called,
    /// Then it should return a list of SCIMGroup objects.
    /// </summary>
    [Fact]
    public async Task GetAllRepoItems_ReturnsListOfSCIMGroups()
    {
        // Arrange: Prepare dummy JSON for a SCIMGroupsResult.
        const string json = """
                            {
                              "meta": {
                                "totalCount": 1242
                              },
                              "filters": [
                                "string"
                              ],
                              "links": {
                                "first": "/api/jsonapi/channel/v1/edusources/repoItems?page[size]=2&page[number]=1",
                                "self": "/api/jsonapi/channel/v1/edusources/repoItems?page[size]=2&page[number]=1",
                                "next": "/api/jsonapi/channel/v1/edusources/repoItems?page[size]=2&page[number]=2",
                                "last": "/api/jsonapi/channel/v1/edusources/repoItems?page[size]=2&page[number]=1112"
                              },
                              "data": [
                                {
                                  "attributes": {
                                    "owner": {
                                      "id": "6949c6f2-517c-4c3e-881f-3d712e0b0640",
                                      "name": "Title institute",
                                      "type": "organisation"
                                    },
                                    "consortium": "Stimuleringsregeling Open en Online Onderwijs",
                                    "typicalAgeRange": null,
                                    "cost": {
                                      "source": null,
                                      "value": null
                                    },
                                    "urn:nbn": null,
                                    "modifiedAt": "2023-11-09T11:24:46Z",
                                    "title": "EDUSOURCES: Test embargo, verloopt op 10-11-2023: 1 bestand restriced en 1 bestand closed",
                                    "subtitle": null,
                                    "publishers": [
                                      "University of Harderwijk (TEST) organisatie"
                                    ],
                                    "publishedAt": "2023",
                                    "place": null,
                                    "abstract": "test",
                                    "keywords": [
                                      "biology"
                                    ],
                                    "numOfPages": null,
                                    "links": [
                                      {
                                        "url": "https://nos.nl",
                                        "accessRight": "openaccess",
                                        "urlName": "NOS"
                                      }
                                    ],
                                    "authors": [
                                      {
                                        "person": {
                                          "id": "40ebd0f9-72f5-41bc-8816-860cfa3dea45",
                                          "name": "John Doe",
                                          "email": "johndoe@example.org",
                                          "dai": "info:eu-repo/dai/nl/123456785",
                                          "orcid": "0000-0001-5109-3700",
                                          "isni": "ISNI 0000 0001 2149 1740"
                                        },
                                        "role": "Begeleider"
                                      }
                                    ],
                                    "files": [
                                      {
                                        "fileName": "Test bestand",
                                        "accessRight": "openaccess",
                                        "eTag": "73e3d03235b03bec89514603f4aca86f",
                                        "url": "https://www.location.file.url",
                                        "resourceMimeType": "text/plain"
                                      }
                                    ],
                                    "institutes": [
                                      {
                                        "name": "Bedrijfscommunicatie",
                                        "type": "discipline",
                                        "id": "ff133bfb-adb1-4dc5-b462-1ee57a14134e"
                                      }
                                    ],
                                    "language": "de",
                                    "themesResearchObject": null,
                                    "termsOfUse": "cc-by-40",
                                    "educationalLevels": [
                                      {
                                        "source": "http://purl.edustandaard.nl/vdex_context_czp_20060628.xml",
                                        "value": "HBO"
                                      }
                                    ],
                                    "typeResearchObject": null,
                                    "typesLearningMaterial": [
                                      "document"
                                    ],
                                    "themesLearningMaterial": [
                                      "exact_informatica"
                                    ],
                                    "hasParts": [
                                      "6c70e6b8-0173-4eff-99ed-1f3218c426dc"
                                    ],
                                    "partOf": [
                                      "string"
                                    ],
                                    "technicalFormat": "printable-object",
                                    "vocabularies": {
                                      "vocabularyZiezo": [
                                        {
                                          "source": "http://purl.edustandaard.nl/concept/c4fdab5a4-224f-4774-bfe5-71eecf669083",
                                          "value": "Afnemen meetinstrument"
                                        }
                                      ],
                                      "vocabularyDas": [
                                        {
                                          "source": "http://purl.edustandaard.nl/concept/6d78d67c-9d42-4f57-9fa2-b24aabbcf892",
                                          "value": "Chemistry"
                                        }
                                      ],
                                      "vocabularyInformationLiteracy": [
                                        {
                                          "source": "http://purl.edustandaard.nl/concept/9805b56e-4fe8-46b2-9fb0-76ee2026d47b",
                                          "value": "Identificeren van informatiebehoefte"
                                        }
                                      ],
                                      "vocabularyVerpleegkunde": [
                                        {
                                          "source": "http://purl.edustandaard.nl/concept/20c66254-fbf7-4ae6-b4c1-29101adc1376",
                                          "value": "Reflectieve EBP-professional"
                                        }
                                      ],
                                      "vocabularyVaktherapie": [
                                        {
                                          "source": "http://purl.edustandaard.nl/concept/07c606df-bb05-4588-9f59-7f83a48f04e0",
                                          "value": "Kritische houding"
                                        }
                                      ]
                                    },
                                    "aggregationlevel": "1",
                                    "intendedUser": "learner",
                                    "doi": "10.80467/8b0f8e7a-4ac8-4401-81ff-59cfec949f48",
                                    "availability": null,
                                    "handle": null,
                                    "publishedIn": {
                                      "title": "Publication Title",
                                      "publisherDocument": "Publisher Document",
                                      "placeOfPublication": "Publication Place",
                                      "year": 2023,
                                      "issue": "Publication Issue",
                                      "edition": "Publication Edition",
                                      "issn": "1234-5678",
                                      "isbn": "978-1-2345-6789-0",
                                      "pageStart": 1,
                                      "pageEnd": 10
                                    },
                                    "conference": null
                                  },
                                  "type": "repoItem",
                                  "id": "7c90e92e-712a-423f-9d62-a15d38ef28ed"
                                }
                              ]
                            }
                            """;

        FakeHttpMessageHandler handler = new(json, HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SURFSharekitApiClient client = new(httpClient);

        // Act
        var repoItems = await client.GetAllRepoItems();

        // Assert
        Assert.NotNull(repoItems);
        Assert.Single(repoItems);
        SURFSharekitRepoItem firstRepoItem = repoItems[0];

        Assert.Equal("7c90e92e-712a-423f-9d62-a15d38ef28ed", firstRepoItem.Id);
        Assert.Equal("repoItem", firstRepoItem.Type);

        Assert.NotNull(firstRepoItem.Attributes);
        Assert.Equal("10.80467/8b0f8e7a-4ac8-4401-81ff-59cfec949f48", firstRepoItem.Attributes.Doi);

        Assert.NotNull(firstRepoItem.Attributes.Vocabularies);
        Assert.Equal("http://purl.edustandaard.nl/concept/6d78d67c-9d42-4f57-9fa2-b24aabbcf892",
            firstRepoItem.Attributes.Vocabularies.VocabularyDas[0].Source);

        Assert.NotNull(firstRepoItem.Attributes.Owner);
        Assert.Equal("6949c6f2-517c-4c3e-881f-3d712e0b0640", firstRepoItem.Attributes.Owner.Id);
    }

    [Fact]
    public async Task GetAllRepoItems_ShouldThrow_WhenResponseIsNull()
    {
        // Arrange: Prepare dummy JSON for a SCIMGroupsResult.
        const string? json = null;

        FakeHttpMessageHandler handler = new(json, HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SURFSharekitApiClient client = new(httpClient);

        // Act & Assert
        await Assert.ThrowsAnyAsync<Exception>(async () =>
        {
            await client.GetAllRepoItems();
        });
    }
    
    [Fact]
    public async Task GetRepoItemById_ShouldThrow_WhenResponseIsNull()
    {
        // Arrange: Prepare dummy JSON for a SCIMGroupsResult.
        const string? json = null;

        FakeHttpMessageHandler handler = new(json, HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SURFSharekitApiClient client = new(httpClient);

        // Act & Assert
        await Assert.ThrowsAnyAsync<Exception>(async () =>
        {
            await client.GetRepoItemById("dummy-id");
        });
    }

}
