// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsCreatePSNEvent : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("events")]
        public List<ModelsPSNEvent>? Events { get; set; }

        [JsonPropertyName("thirdPartyUserId")]
        public string? ThirdPartyUserId { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


}