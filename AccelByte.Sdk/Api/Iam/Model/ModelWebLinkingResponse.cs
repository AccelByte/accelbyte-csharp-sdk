// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelWebLinkingResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("third_party_url")]
        public string? ThirdPartyUrl { get; set; }

    }
}