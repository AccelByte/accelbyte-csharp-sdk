// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Tests
{
    public class HttpbinAnythingResponse<TArgs> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("method")]
        public string Method { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        [JsonPropertyName("headers")]
        public Dictionary<string, string>? Headers { get; set; }

        [JsonPropertyName("args")]
        public TArgs? Args { get; set; }

        [JsonPropertyName("form")]
        public Dictionary<string, string>? Form { get; set; }

        [JsonPropertyName("data")]
        public string Data { get; set; } = string.Empty;

        [JsonPropertyName("files")]
        public Dictionary<string,string>? Files { get; set; }
    }

    public class HttpbinAnythingResponse<TArgs, TData> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("method")]
        public string Method { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

        [JsonPropertyName("headers")]
        public Dictionary<string, string>? Headers { get; set; }

        [JsonPropertyName("args")]
        public TArgs? Args { get; set; }

        [JsonPropertyName("form")]
        public Dictionary<string, string>? Form { get; set; }

        [JsonPropertyName("json")]
        public TData? Data { get; set; }

        [JsonPropertyName("files")]
        public Dictionary<string, string>? Files { get; set; }
    }
}