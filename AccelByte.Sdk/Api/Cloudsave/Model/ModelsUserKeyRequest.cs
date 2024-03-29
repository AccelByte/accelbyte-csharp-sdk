// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsUserKeyRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("keys")]
        public List<string>? Keys { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }


}