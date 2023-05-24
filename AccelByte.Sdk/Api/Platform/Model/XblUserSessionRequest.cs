// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblUserSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("gameSessionId")]
        public string? GameSessionId { get; set; }

        [JsonPropertyName("payload")]
        public Dictionary<string, object>? Payload { get; set; }

        [JsonPropertyName("scid")]
        public string? Scid { get; set; }

        [JsonPropertyName("sessionTemplateName")]
        public string? SessionTemplateName { get; set; }

    }

    public class XblUserSessionRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("gameSessionId")]
        public string? GameSessionId { get; set; }

        [JsonPropertyName("payload")]
        public T1? Payload { get; set; }

        [JsonPropertyName("scid")]
        public string? Scid { get; set; }

        [JsonPropertyName("sessionTemplateName")]
        public string? SessionTemplateName { get; set; }

    }

}