// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Operation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("creditPayload")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CreditPayload? CreditPayload { get; set; }

        [JsonPropertyName("debitPayload")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DebitPayload? DebitPayload { get; set; }

        [JsonPropertyName("fulFillItemPayload")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public FulFillItemPayload? FulFillItemPayload { get; set; }

        [JsonPropertyName("resultId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ResultId { get; set; }

        [JsonPropertyName("revokeEntitlementPayload")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RevokeEntitlementPayload? RevokeEntitlementPayload { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public OperationStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public OperationType? Type { get; set; }

    }



    public class OperationStatus : StringEnum<OperationStatus>
    {
        public static readonly OperationStatus FAILED
            = new OperationStatus("FAILED");

        public static readonly OperationStatus INIT
            = new OperationStatus("INIT");

        public static readonly OperationStatus SKIPPED
            = new OperationStatus("SKIPPED");

        public static readonly OperationStatus SUCCESS
            = new OperationStatus("SUCCESS");


        public static implicit operator OperationStatus(string value)
        {
            return NewValue(value);
        }

        public OperationStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class OperationType : StringEnum<OperationType>
    {
        public static readonly OperationType CREDITWALLET
            = new OperationType("CREDIT_WALLET");

        public static readonly OperationType DEBITWALLET
            = new OperationType("DEBIT_WALLET");

        public static readonly OperationType FULFILLITEM
            = new OperationType("FULFILL_ITEM");

        public static readonly OperationType REVOKEENTITLEMENT
            = new OperationType("REVOKE_ENTITLEMENT");


        public static implicit operator OperationType(string value)
        {
            return NewValue(value);
        }

        public OperationType(string enumValue)
            : base(enumValue)
        {

        }
    }
}