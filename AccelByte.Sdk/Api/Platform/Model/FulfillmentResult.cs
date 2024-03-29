// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("creditSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CreditSummary>? CreditSummaries { get; set; }

        [JsonPropertyName("entitlementSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementSummary>? EntitlementSummaries { get; set; }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("subscriptionSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SubscriptionSummary>? SubscriptionSummaries { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }


}