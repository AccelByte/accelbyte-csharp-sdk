// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentActionHistory : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FulfillmentActionHistoryAction? Action { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("fulfillmentHistoryId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FulfillmentHistoryId { get; set; }

        [JsonPropertyName("revocationHistoryId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RevocationHistoryId { get; set; }

        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FulfillmentActionHistoryState? State { get; set; }

    }



    public class FulfillmentActionHistoryAction : StringEnum<FulfillmentActionHistoryAction>
    {
        public static readonly FulfillmentActionHistoryAction FULFILLMENT
            = new FulfillmentActionHistoryAction("FULFILLMENT");

        public static readonly FulfillmentActionHistoryAction REVOKEFULFILLMENT
            = new FulfillmentActionHistoryAction("REVOKE_FULFILLMENT");


        public static implicit operator FulfillmentActionHistoryAction(string value)
        {
            return NewValue(value);
        }

        public FulfillmentActionHistoryAction(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class FulfillmentActionHistoryState : StringEnum<FulfillmentActionHistoryState>
    {
        public static readonly FulfillmentActionHistoryState FULFILLED
            = new FulfillmentActionHistoryState("FULFILLED");

        public static readonly FulfillmentActionHistoryState FULFILLFAILED
            = new FulfillmentActionHistoryState("FULFILL_FAILED");

        public static readonly FulfillmentActionHistoryState REVOKED
            = new FulfillmentActionHistoryState("REVOKED");

        public static readonly FulfillmentActionHistoryState REVOKEFAILED
            = new FulfillmentActionHistoryState("REVOKE_FAILED");


        public static implicit operator FulfillmentActionHistoryState(string value)
        {
            return NewValue(value);
        }

        public FulfillmentActionHistoryState(string enumValue)
            : base(enumValue)
        {

        }
    }
}