// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        [JsonStringEnum]
        public OrderUpdateStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }

    }

    public class OrderUpdateStatus : StringEnum<OrderUpdateStatus>
    {
        public static readonly OrderUpdateStatus INIT
            = new OrderUpdateStatus("INIT");

        public static readonly OrderUpdateStatus CHARGED
            = new OrderUpdateStatus("CHARGED");

        public static readonly OrderUpdateStatus CHARGEBACK
            = new OrderUpdateStatus("CHARGEBACK");

        public static readonly OrderUpdateStatus CHARGEBACKREVERSED
            = new OrderUpdateStatus("CHARGEBACK_REVERSED");

        public static readonly OrderUpdateStatus FULFILLED
            = new OrderUpdateStatus("FULFILLED");

        public static readonly OrderUpdateStatus FULFILLFAILED
            = new OrderUpdateStatus("FULFILL_FAILED");

        public static readonly OrderUpdateStatus REFUNDING
            = new OrderUpdateStatus("REFUNDING");

        public static readonly OrderUpdateStatus REFUNDED
            = new OrderUpdateStatus("REFUNDED");

        public static readonly OrderUpdateStatus REFUNDFAILED
            = new OrderUpdateStatus("REFUND_FAILED");

        public static readonly OrderUpdateStatus CLOSED
            = new OrderUpdateStatus("CLOSED");

        public static readonly OrderUpdateStatus DELETED
            = new OrderUpdateStatus("DELETED");


        public static implicit operator OrderUpdateStatus(string value)
        {
            return Create(value);
        }

        public OrderUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}