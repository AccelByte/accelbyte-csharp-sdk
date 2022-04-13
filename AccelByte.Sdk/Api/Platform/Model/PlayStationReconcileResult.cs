// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlayStationReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("psnItemId")]
        public string? PsnItemId { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PlayStationReconcileResultStatus? Status { get; set; }

        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

    }

    public class PlayStationReconcileResultStatus : StringEnum<PlayStationReconcileResultStatus>
    {
        public static readonly PlayStationReconcileResultStatus VERIFIED
            = new PlayStationReconcileResultStatus("VERIFIED");

        public static readonly PlayStationReconcileResultStatus FULFILLED
            = new PlayStationReconcileResultStatus("FULFILLED");

        public static readonly PlayStationReconcileResultStatus FAILED
            = new PlayStationReconcileResultStatus("FAILED");


        public static implicit operator PlayStationReconcileResultStatus(string value)
        {
            return Create(value);
        }

        public PlayStationReconcileResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}