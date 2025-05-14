// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Net;

namespace SURFSharekit.Net.Tests.Helpers;

/// <summary>
/// A fake HTTP message handler for testing purposes.
/// </summary>
// ReSharper disable once InconsistentNaming
public class FakeHttpMessageHandler : HttpMessageHandler
{
    private readonly string? _responseContent;
    private readonly HttpStatusCode _statusCode;

    public FakeHttpMessageHandler(string? responseContent, HttpStatusCode statusCode)
    {
        _responseContent = responseContent;
        _statusCode = statusCode;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        HttpResponseMessage response = new(_statusCode)
        {
            Content = _responseContent != null ? new StringContent(_responseContent) : null,
        };
        return Task.FromResult(response);
    }
}
