// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementDecrementResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementDecrementResultAppType? AppType { get; set; }

        [JsonPropertyName("clazz")]
        [JsonStringEnum]
        public EntitlementDecrementResultClazz? Clazz { get; set; }

        [JsonPropertyName("collectionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CollectionId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("grantedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? GrantedAt { get; set; }

        [JsonPropertyName("grantedCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GrantedCode { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemNamespace")]
        public string? ItemNamespace { get; set; }

        [JsonPropertyName("itemSnapshot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("noOrigin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? NoOrigin { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementDecrementResultOrigin? Origin { get; set; }

        [JsonPropertyName("platformAvailable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? PlatformAvailable { get; set; }

        [JsonPropertyName("replayed")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Replayed { get; set; }

        [JsonPropertyName("requestId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RequestId { get; set; }

        [JsonPropertyName("rewards")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementLootBoxReward>? Rewards { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementDecrementResultSource? Source { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public EntitlementDecrementResultStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StoreId { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementDecrementResultType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

    }



    public class EntitlementDecrementResultAppType : StringEnum<EntitlementDecrementResultAppType>
    {
        public static readonly EntitlementDecrementResultAppType DEMO
            = new EntitlementDecrementResultAppType("DEMO");

        public static readonly EntitlementDecrementResultAppType DLC
            = new EntitlementDecrementResultAppType("DLC");

        public static readonly EntitlementDecrementResultAppType GAME
            = new EntitlementDecrementResultAppType("GAME");

        public static readonly EntitlementDecrementResultAppType SOFTWARE
            = new EntitlementDecrementResultAppType("SOFTWARE");


        public static implicit operator EntitlementDecrementResultAppType(string value)
        {
            return NewValue(value);
        }

        public EntitlementDecrementResultAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementDecrementResultClazz : StringEnum<EntitlementDecrementResultClazz>
    {
        public static readonly EntitlementDecrementResultClazz APP
            = new EntitlementDecrementResultClazz("APP");

        public static readonly EntitlementDecrementResultClazz CODE
            = new EntitlementDecrementResultClazz("CODE");

        public static readonly EntitlementDecrementResultClazz ENTITLEMENT
            = new EntitlementDecrementResultClazz("ENTITLEMENT");

        public static readonly EntitlementDecrementResultClazz LOOTBOX
            = new EntitlementDecrementResultClazz("LOOTBOX");

        public static readonly EntitlementDecrementResultClazz MEDIA
            = new EntitlementDecrementResultClazz("MEDIA");

        public static readonly EntitlementDecrementResultClazz OPTIONBOX
            = new EntitlementDecrementResultClazz("OPTIONBOX");

        public static readonly EntitlementDecrementResultClazz SUBSCRIPTION
            = new EntitlementDecrementResultClazz("SUBSCRIPTION");


        public static implicit operator EntitlementDecrementResultClazz(string value)
        {
            return NewValue(value);
        }

        public EntitlementDecrementResultClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementDecrementResultOrigin : StringEnum<EntitlementDecrementResultOrigin>
    {
        public static readonly EntitlementDecrementResultOrigin Epic
            = new EntitlementDecrementResultOrigin("Epic");

        public static readonly EntitlementDecrementResultOrigin GooglePlay
            = new EntitlementDecrementResultOrigin("GooglePlay");

        public static readonly EntitlementDecrementResultOrigin IOS
            = new EntitlementDecrementResultOrigin("IOS");

        public static readonly EntitlementDecrementResultOrigin Nintendo
            = new EntitlementDecrementResultOrigin("Nintendo");

        public static readonly EntitlementDecrementResultOrigin Oculus
            = new EntitlementDecrementResultOrigin("Oculus");

        public static readonly EntitlementDecrementResultOrigin Other
            = new EntitlementDecrementResultOrigin("Other");

        public static readonly EntitlementDecrementResultOrigin Playstation
            = new EntitlementDecrementResultOrigin("Playstation");

        public static readonly EntitlementDecrementResultOrigin Steam
            = new EntitlementDecrementResultOrigin("Steam");

        public static readonly EntitlementDecrementResultOrigin System
            = new EntitlementDecrementResultOrigin("System");

        public static readonly EntitlementDecrementResultOrigin Twitch
            = new EntitlementDecrementResultOrigin("Twitch");

        public static readonly EntitlementDecrementResultOrigin Xbox
            = new EntitlementDecrementResultOrigin("Xbox");


        public static implicit operator EntitlementDecrementResultOrigin(string value)
        {
            return NewValue(value);
        }

        public EntitlementDecrementResultOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementDecrementResultSource : StringEnum<EntitlementDecrementResultSource>
    {
        public static readonly EntitlementDecrementResultSource ACHIEVEMENT
            = new EntitlementDecrementResultSource("ACHIEVEMENT");

        public static readonly EntitlementDecrementResultSource GIFT
            = new EntitlementDecrementResultSource("GIFT");

        public static readonly EntitlementDecrementResultSource IAP
            = new EntitlementDecrementResultSource("IAP");

        public static readonly EntitlementDecrementResultSource OTHER
            = new EntitlementDecrementResultSource("OTHER");

        public static readonly EntitlementDecrementResultSource PROMOTION
            = new EntitlementDecrementResultSource("PROMOTION");

        public static readonly EntitlementDecrementResultSource PURCHASE
            = new EntitlementDecrementResultSource("PURCHASE");

        public static readonly EntitlementDecrementResultSource REDEEMCODE
            = new EntitlementDecrementResultSource("REDEEM_CODE");

        public static readonly EntitlementDecrementResultSource REFERRALBONUS
            = new EntitlementDecrementResultSource("REFERRAL_BONUS");

        public static readonly EntitlementDecrementResultSource REWARD
            = new EntitlementDecrementResultSource("REWARD");


        public static implicit operator EntitlementDecrementResultSource(string value)
        {
            return NewValue(value);
        }

        public EntitlementDecrementResultSource(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementDecrementResultStatus : StringEnum<EntitlementDecrementResultStatus>
    {
        public static readonly EntitlementDecrementResultStatus ACTIVE
            = new EntitlementDecrementResultStatus("ACTIVE");

        public static readonly EntitlementDecrementResultStatus CONSUMED
            = new EntitlementDecrementResultStatus("CONSUMED");

        public static readonly EntitlementDecrementResultStatus INACTIVE
            = new EntitlementDecrementResultStatus("INACTIVE");

        public static readonly EntitlementDecrementResultStatus REVOKED
            = new EntitlementDecrementResultStatus("REVOKED");

        public static readonly EntitlementDecrementResultStatus SOLD
            = new EntitlementDecrementResultStatus("SOLD");


        public static implicit operator EntitlementDecrementResultStatus(string value)
        {
            return NewValue(value);
        }

        public EntitlementDecrementResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementDecrementResultType : StringEnum<EntitlementDecrementResultType>
    {
        public static readonly EntitlementDecrementResultType CONSUMABLE
            = new EntitlementDecrementResultType("CONSUMABLE");

        public static readonly EntitlementDecrementResultType DURABLE
            = new EntitlementDecrementResultType("DURABLE");


        public static implicit operator EntitlementDecrementResultType(string value)
        {
            return NewValue(value);
        }

        public EntitlementDecrementResultType(string enumValue)
            : base(enumValue)
        {

        }
    }
}