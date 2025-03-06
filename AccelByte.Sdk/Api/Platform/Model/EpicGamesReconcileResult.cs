// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EpicGamesReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("epicGamesItemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EpicGamesItemId { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EpicGamesReconcileResultStatus? Status { get; set; }

        [JsonPropertyName("transactionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TransactionId { get; set; }

    }



    public class EpicGamesReconcileResultStatus : StringEnum<EpicGamesReconcileResultStatus>
    {
        public static readonly EpicGamesReconcileResultStatus FAILED
            = new EpicGamesReconcileResultStatus("FAILED");

        public static readonly EpicGamesReconcileResultStatus FULFILLED
            = new EpicGamesReconcileResultStatus("FULFILLED");

        public static readonly EpicGamesReconcileResultStatus PARTIALREVOKED
            = new EpicGamesReconcileResultStatus("PARTIAL_REVOKED");

        public static readonly EpicGamesReconcileResultStatus REVOKED
            = new EpicGamesReconcileResultStatus("REVOKED");

        public static readonly EpicGamesReconcileResultStatus REVOKEFAILED
            = new EpicGamesReconcileResultStatus("REVOKE_FAILED");

        public static readonly EpicGamesReconcileResultStatus VERIFIED
            = new EpicGamesReconcileResultStatus("VERIFIED");


        public static implicit operator EpicGamesReconcileResultStatus(string value)
        {
            return NewValue(value);
        }

        public EpicGamesReconcileResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}