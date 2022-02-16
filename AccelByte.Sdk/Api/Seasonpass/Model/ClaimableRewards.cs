// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ClaimableRewards : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claimingRewards")]
        public Dictionary<string, object>? ClaimingRewards { get; set; }
        
        [JsonPropertyName("toClaimRewards")]
        public Dictionary<string, object>? ToClaimRewards { get; set; }
        
    }
}