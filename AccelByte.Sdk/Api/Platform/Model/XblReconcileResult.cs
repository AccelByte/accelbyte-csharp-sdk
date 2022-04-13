// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("iapOrderStatus")]
        [JsonStringEnum]
        public XblReconcileResultIapOrderStatus? IapOrderStatus { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        [JsonPropertyName("xboxProductId")]
        public string? XboxProductId { get; set; }

    }

    public class XblReconcileResultIapOrderStatus : StringEnum<XblReconcileResultIapOrderStatus>
    {
        public static readonly XblReconcileResultIapOrderStatus VERIFIED
            = new XblReconcileResultIapOrderStatus("VERIFIED");

        public static readonly XblReconcileResultIapOrderStatus FULFILLED
            = new XblReconcileResultIapOrderStatus("FULFILLED");

        public static readonly XblReconcileResultIapOrderStatus FAILED
            = new XblReconcileResultIapOrderStatus("FAILED");


        public static implicit operator XblReconcileResultIapOrderStatus(string value)
        {
            return Create(value);
        }

        public XblReconcileResultIapOrderStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}