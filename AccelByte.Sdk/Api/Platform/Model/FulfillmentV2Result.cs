// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentV2Result : AccelByte.Sdk.Core.Model
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

        [JsonPropertyName("items")]
        public List<FulfillmentItem>? Items { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("state")]
        [JsonStringEnum]
        public FulfillmentV2ResultState? State { get; set; }

        [JsonPropertyName("stateInfo")]
        public FulfillmentStateInfo? StateInfo { get; set; }

        [JsonPropertyName("subscriptionSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SubscriptionSummary>? SubscriptionSummaries { get; set; }

        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class FulfillmentV2ResultState : StringEnum<FulfillmentV2ResultState>
    {
        public static readonly FulfillmentV2ResultState FULFILLED
            = new FulfillmentV2ResultState("FULFILLED");

        public static readonly FulfillmentV2ResultState FULFILLFAILED
            = new FulfillmentV2ResultState("FULFILL_FAILED");

        public static readonly FulfillmentV2ResultState REVOKED
            = new FulfillmentV2ResultState("REVOKED");

        public static readonly FulfillmentV2ResultState REVOKEFAILED
            = new FulfillmentV2ResultState("REVOKE_FAILED");


        public static implicit operator FulfillmentV2ResultState(string value)
        {
            return NewValue(value);
        }

        public FulfillmentV2ResultState(string enumValue)
            : base(enumValue)
        {

        }
    }
}