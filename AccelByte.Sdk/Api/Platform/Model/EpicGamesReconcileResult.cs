// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EpicGamesReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("epicGamesItemId")]
        public string? EpicGamesItemId { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public EpicGamesReconcileResultStatus? Status { get; set; }

        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

    }

    public class EpicGamesReconcileResultStatus : StringEnum<EpicGamesReconcileResultStatus>
    {
        public static readonly EpicGamesReconcileResultStatus VERIFIED
            = new EpicGamesReconcileResultStatus("VERIFIED");

        public static readonly EpicGamesReconcileResultStatus FULFILLED
            = new EpicGamesReconcileResultStatus("FULFILLED");

        public static readonly EpicGamesReconcileResultStatus FAILED
            = new EpicGamesReconcileResultStatus("FAILED");


        public static implicit operator EpicGamesReconcileResultStatus(string value)
        {
            return Create(value);
        }

        public EpicGamesReconcileResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}