// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)
using SURFSharekit.Net.Tests.Helpers;
using System.Net;
using SURFSharekit.Net.Models;
using Xunit;

namespace SURFSharekit.Net.Tests;

public class SURFSharekitApiClientTests
{
    [Fact]
    public void SetBearerToken_SetsAuthorizationHeader()
    {
        // Arrange
        string token = "VeryValidToken";
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
    /// Given a valid <see cref="SURFSharekitApiClient"/>,
    /// When GetRepoItemById is called,
    /// Then it should return the <see cref="SURFSharekitRepoItem"/> specified by that id.
    /// </summary>
    [Fact]
    public async Task GetRepoItemById_ReturnsRepoItem()
    {
        // Arrange: Prepare a dummy JSON response for SCIMGroup.
        // dummy json obtained from api specification
        string json = """
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
        Assert.NotNull(item.SURFSharekitAttributes);
        Assert.Equal("Test Title", item.SURFSharekitAttributes.Title);
        Assert.NotEmpty(item.SURFSharekitAttributes.Authors);
        Assert.Equal("John Doe", item.SURFSharekitAttributes.Authors[0].SURFSharekitPerson.Name);
    }

    /// <summary>
    /// Given a valid SCIM API client,
    /// When GetAllGroups is called,
    /// Then it should return a list of SCIMGroup objects.
    /// </summary>
    [Fact]
    public async Task GetAllGroups_ReturnsListOfSCIMGroups()
    {
        // Arrange: Prepare dummy JSON for a SCIMGroupsResult.
        // Note: The top-level property is "Resources" to match the SCIMGroupsResult class.
        const string json = """
                            {
                                "Resources": [
                                    {
                                        "id": "dummy-id",
                                        "displayName": "Test Group",
                                        "externalId": "external-id",
                                        "urn:mace:surf.nl:sram:scim:extension:Group": {
                                            "urn": "dummy-urn",
                                            "description": "Dummy description",
                                            "links": [
                                                { "name": "sbs_url", "value": "http://example.com" },
                                                { "name": "logo", "value": "http://example.com/logo.png" }
                                            ]
                                        },
                                        "members": [
                                            { "$ref": "ref1", "display": "Test Member", "value": "member1", "type": "user" }
                                        ],
                                        "meta": {
                                            "created": "2023-01-01T00:00:00Z",
                                            "location": "https://example.com",
                                            "resourceType": "Group",
                                            "version": "1.0"
                                        },
                                        "schemas": [
                                            "urn:mace:surf.nl:sram:scim:extension:Group"
                                        ]
                                    }
                                ],
                                "itemsPerPage": 1,
                                "schemas": [ "urn:ietf:params:scim:schemas:core:2.0:ListResponse" ],
                                "startIndex": 1,
                                "totalResults": 1
                            }
                            """;

        FakeHttpMessageHandler handler = new(json, HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SCIMApiClient client = new(httpClient);

        // Act
        var groups = await client.GetAllGroups();

        // Assert
        Assert.NotNull(groups);
        Assert.Single(groups);
        SCIMGroup firstGroup = groups[0];
        Assert.Equal("dummy-id", firstGroup.Id);
        Assert.Equal("Test Group", firstGroup.DisplayName);
    }

    /// <summary>
    /// Given a valid SCIM API client,
    /// When GetSCIMMemberByExternalId is called with a valid ID,
    /// Then it should return a SCIMUser object.
    /// </summary>
    [Fact]
    public async Task GetSCIMMemberByExternalId_ReturnsSCIMUser()
    {
        // Arrange: Prepare dummy JSON response for a SCIMUser.
        const string json = """
                            {
                                "id": "member1",
                                "userName": "testuser",
                                "displayName": "Test User",
                                "emails": [ { "value": "testuser@example.com" } ]
                            }
                            """;

        FakeHttpMessageHandler handler = new(json, HttpStatusCode.OK);
        HttpClient httpClient = new(handler)
        {
            BaseAddress = new("https://dummy/"),
        };
        SCIMApiClient client = new(httpClient);

        // Act
        SCIMUser? user = await client.GetSCIMMemberByExternalId("member1");

        // Assert
        Assert.NotNull(user);
        Assert.Equal("member1", user.Id);
        Assert.Equal("testuser", user.UserName);
        Assert.Equal("Test User", user.DisplayName);
        Assert.NotNull(user.Emails);
        Assert.NotEmpty(user.Emails);
        Assert.Equal("testuser@example.com", user.Emails[0].Value);
    }
}