// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonStringEnum]
        public OrderHistoryInfoAction? Action { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class OrderHistoryInfoAction : StringEnum<OrderHistoryInfoAction>
    {
        public static readonly OrderHistoryInfoAction INIT
            = new OrderHistoryInfoAction("INIT");

        public static readonly OrderHistoryInfoAction CHARGED
            = new OrderHistoryInfoAction("CHARGED");

        public static readonly OrderHistoryInfoAction CHARGEBACK
            = new OrderHistoryInfoAction("CHARGEBACK");

        public static readonly OrderHistoryInfoAction CHARGEBACKREVERSED
            = new OrderHistoryInfoAction("CHARGEBACK_REVERSED");

        public static readonly OrderHistoryInfoAction FULFILLED
            = new OrderHistoryInfoAction("FULFILLED");

        public static readonly OrderHistoryInfoAction FULFILLFAILED
            = new OrderHistoryInfoAction("FULFILL_FAILED");

        public static readonly OrderHistoryInfoAction REFUNDING
            = new OrderHistoryInfoAction("REFUNDING");

        public static readonly OrderHistoryInfoAction REFUNDED
            = new OrderHistoryInfoAction("REFUNDED");

        public static readonly OrderHistoryInfoAction REFUNDFAILED
            = new OrderHistoryInfoAction("REFUND_FAILED");

        public static readonly OrderHistoryInfoAction CLOSE
            = new OrderHistoryInfoAction("CLOSE");

        public static readonly OrderHistoryInfoAction DELETED
            = new OrderHistoryInfoAction("DELETED");

        public static readonly OrderHistoryInfoAction SETSTATUS
            = new OrderHistoryInfoAction("SET_STATUS");


        public static implicit operator OrderHistoryInfoAction(string value)
        {
            return Create(value);
        }

        public OrderHistoryInfoAction(string enumValue)
            : base(enumValue)
        {

        }
    }    
}