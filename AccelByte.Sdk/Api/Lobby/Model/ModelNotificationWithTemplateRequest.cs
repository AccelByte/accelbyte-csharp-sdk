// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelNotificationWithTemplateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("templateContext")]
        public Dictionary<string, string>? TemplateContext { get; set; }

        [JsonPropertyName("templateLanguage")]
        public string? TemplateLanguage { get; set; }

        [JsonPropertyName("templateSlug")]
        public string? TemplateSlug { get; set; }

        [JsonPropertyName("topic")]
        public string? Topic { get; set; }

    }
}