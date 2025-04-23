// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using System.Text.Json;
using System.Text.Json.Serialization;
using SURFSharekit.Net;

namespace SURFSharekit.Net;

public class DoiConverter : JsonConverter<Sharekit>
{
    public override Sharekit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? doiString = reader.GetString();
        if (doiString is null)
            throw new JsonException("Expected a string value.");
        try
        {
            return Sharekit.Parse(doiString);
        }
        catch (ArgumentException e)
        {
            throw new JsonException("Could not parse DOI", e);
        }
    }

    public override void Write(Utf8JsonWriter writer, Sharekit value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}
