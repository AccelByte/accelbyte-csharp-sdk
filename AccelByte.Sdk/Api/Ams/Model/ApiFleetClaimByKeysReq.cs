// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiFleetClaimByKeysReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claimKeys")]
        public List<string>? ClaimKeys { get; set; }

        [JsonPropertyName("regions")]
        public List<string>? Regions { get; set; }

        [JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

    }


}