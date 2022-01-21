using System.Collections.Generic;
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests
{
    public class HttpbinAnythingResponse<TArgs> : Model
    {
        [JsonPropertyName("method")]
        public string? Method { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("headers")]
        public Dictionary<string, string>? Headers { get; set; }

        [JsonPropertyName("args")]
        public TArgs? Args { get; set; }

        [JsonPropertyName("form")]
        public Dictionary<string, string>? Form { get; set; }

        [JsonPropertyName("data")]
        public string? Data { get; set; }
    }
}