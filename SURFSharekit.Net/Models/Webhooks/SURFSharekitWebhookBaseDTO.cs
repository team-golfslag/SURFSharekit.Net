// This program has been developed by students from the bachelor Computer Science at Utrecht
// University within the Software Project course.
// 
// © Copyright Utrecht University (Department of Information and Computing Sciences)

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SURFSharekit.Net.Models.Webhooks;

public class SURFSharekitWebhookBaseDTO
{
    public static SURFSharekitWebhookBaseDTO Deserialize(string json)
    {
        JObject? result = JsonConvert.DeserializeObject<JObject>(json);
        if (result == null) throw new("invalid json");

        if (!result.TryGetValue("type", out JToken? _) || !result.TryGetValue("id", out JToken? _))
            throw new("supplied json is not a webhook response");

        // Create DTO
        if (result.TryGetValue("attributes", out JToken? createAttributes) && createAttributes is JObject obj && obj.TryGetValue("raid", out JToken? _))
        {
            SURFSharekitWebhookCreateDTO? createDTO = JsonConvert.DeserializeObject<SURFSharekitWebhookCreateDTO>(json);
            if (createDTO is not null) return createDTO;
            throw new("webhook create DTO format is not correct");
        }

        // Delete DTO
        if (result.TryGetValue("attributes", out JToken? _) && result.TryGetValue("meta", out JToken? meta) &&
            meta["deletedAt"] is not null && meta["status"] is not null)
        {
            SURFSharekitWebhookDeleteDTO? deleteDTO = JsonConvert.DeserializeObject<SURFSharekitWebhookDeleteDTO>(json);
            if (deleteDTO is not null) return deleteDTO;
            throw new("webhook delete DTO format is not correct");
        }

        // Update DTO
        // if (false)
        // {
        //     
        // }
        throw new("supplied json is not a webhook response");
    }
}
