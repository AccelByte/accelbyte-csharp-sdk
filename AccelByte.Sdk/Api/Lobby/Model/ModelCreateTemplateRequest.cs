// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelCreateTemplateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("templateContent")]
        public string? TemplateContent { get; set; }

        [JsonPropertyName("templateLanguage")]
        public string? TemplateLanguage { get; set; }

        [JsonPropertyName("templateSlug")]
        public string? TemplateSlug { get; set; }

    }
}