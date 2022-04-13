// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsUserDataURL : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("URL")]
        public string? URL { get; set; }

    }
}