// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class GrantSubscriptionDaysRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("grantDays")]
        public int? GrantDays { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
    }
}