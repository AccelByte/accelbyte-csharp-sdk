// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AdditionalDataEntitlement : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientTransaction")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ClientTransaction>? ClientTransaction { get; set; }

        [JsonPropertyName("entitlementId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EntitlementId { get; set; }

        [JsonPropertyName("usageCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UsageCount { get; set; }

    }


}