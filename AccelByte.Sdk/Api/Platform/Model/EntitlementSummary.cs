// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clazz")]
        [JsonStringEnum]
        public EntitlementSummaryClazz? Clazz { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("grantedCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GrantedCode { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("stackedUseCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? StackedUseCount { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StoreId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public EntitlementSummaryType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class EntitlementSummaryClazz : StringEnum<EntitlementSummaryClazz>
    {
        public static readonly EntitlementSummaryClazz APP
            = new EntitlementSummaryClazz("APP");

        public static readonly EntitlementSummaryClazz CODE
            = new EntitlementSummaryClazz("CODE");

        public static readonly EntitlementSummaryClazz ENTITLEMENT
            = new EntitlementSummaryClazz("ENTITLEMENT");

        public static readonly EntitlementSummaryClazz LOOTBOX
            = new EntitlementSummaryClazz("LOOTBOX");

        public static readonly EntitlementSummaryClazz MEDIA
            = new EntitlementSummaryClazz("MEDIA");

        public static readonly EntitlementSummaryClazz OPTIONBOX
            = new EntitlementSummaryClazz("OPTIONBOX");

        public static readonly EntitlementSummaryClazz SUBSCRIPTION
            = new EntitlementSummaryClazz("SUBSCRIPTION");


        public static implicit operator EntitlementSummaryClazz(string value)
        {
            return NewValue(value);
        }

        public EntitlementSummaryClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementSummaryType : StringEnum<EntitlementSummaryType>
    {
        public static readonly EntitlementSummaryType CONSUMABLE
            = new EntitlementSummaryType("CONSUMABLE");

        public static readonly EntitlementSummaryType DURABLE
            = new EntitlementSummaryType("DURABLE");


        public static implicit operator EntitlementSummaryType(string value)
        {
            return NewValue(value);
        }

        public EntitlementSummaryType(string enumValue)
            : base(enumValue)
        {

        }
    }
}