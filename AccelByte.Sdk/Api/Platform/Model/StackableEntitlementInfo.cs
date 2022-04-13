// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StackableEntitlementInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public StackableEntitlementInfoAppType? AppType { get; set; }

        [JsonPropertyName("clazz")]
        [JsonStringEnum]
        public StackableEntitlementInfoClazz? Clazz { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }

        [JsonPropertyName("grantedAt")]
        public DateTime? GrantedAt { get; set; }

        [JsonPropertyName("grantedCode")]
        public string? GrantedCode { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemNamespace")]
        public string? ItemNamespace { get; set; }

        [JsonPropertyName("itemSnapshot")]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public StackableEntitlementInfoSource? Source { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("stackedUseCount")]
        public int? StackedUseCount { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public StackableEntitlementInfoStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public StackableEntitlementInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class StackableEntitlementInfoAppType : StringEnum<StackableEntitlementInfoAppType>
    {
        public static readonly StackableEntitlementInfoAppType GAME
            = new StackableEntitlementInfoAppType("GAME");

        public static readonly StackableEntitlementInfoAppType SOFTWARE
            = new StackableEntitlementInfoAppType("SOFTWARE");

        public static readonly StackableEntitlementInfoAppType DLC
            = new StackableEntitlementInfoAppType("DLC");

        public static readonly StackableEntitlementInfoAppType DEMO
            = new StackableEntitlementInfoAppType("DEMO");


        public static implicit operator StackableEntitlementInfoAppType(string value)
        {
            return Create(value);
        }

        public StackableEntitlementInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class StackableEntitlementInfoClazz : StringEnum<StackableEntitlementInfoClazz>
    {
        public static readonly StackableEntitlementInfoClazz APP
            = new StackableEntitlementInfoClazz("APP");

        public static readonly StackableEntitlementInfoClazz ENTITLEMENT
            = new StackableEntitlementInfoClazz("ENTITLEMENT");

        public static readonly StackableEntitlementInfoClazz CODE
            = new StackableEntitlementInfoClazz("CODE");

        public static readonly StackableEntitlementInfoClazz SUBSCRIPTION
            = new StackableEntitlementInfoClazz("SUBSCRIPTION");

        public static readonly StackableEntitlementInfoClazz MEDIA
            = new StackableEntitlementInfoClazz("MEDIA");


        public static implicit operator StackableEntitlementInfoClazz(string value)
        {
            return Create(value);
        }

        public StackableEntitlementInfoClazz(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class StackableEntitlementInfoSource : StringEnum<StackableEntitlementInfoSource>
    {
        public static readonly StackableEntitlementInfoSource PURCHASE
            = new StackableEntitlementInfoSource("PURCHASE");

        public static readonly StackableEntitlementInfoSource IAP
            = new StackableEntitlementInfoSource("IAP");

        public static readonly StackableEntitlementInfoSource PROMOTION
            = new StackableEntitlementInfoSource("PROMOTION");

        public static readonly StackableEntitlementInfoSource ACHIEVEMENT
            = new StackableEntitlementInfoSource("ACHIEVEMENT");

        public static readonly StackableEntitlementInfoSource REFERRALBONUS
            = new StackableEntitlementInfoSource("REFERRAL_BONUS");

        public static readonly StackableEntitlementInfoSource REDEEMCODE
            = new StackableEntitlementInfoSource("REDEEM_CODE");

        public static readonly StackableEntitlementInfoSource REWARD
            = new StackableEntitlementInfoSource("REWARD");

        public static readonly StackableEntitlementInfoSource GIFT
            = new StackableEntitlementInfoSource("GIFT");

        public static readonly StackableEntitlementInfoSource OTHER
            = new StackableEntitlementInfoSource("OTHER");


        public static implicit operator StackableEntitlementInfoSource(string value)
        {
            return Create(value);
        }

        public StackableEntitlementInfoSource(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class StackableEntitlementInfoStatus : StringEnum<StackableEntitlementInfoStatus>
    {
        public static readonly StackableEntitlementInfoStatus ACTIVE
            = new StackableEntitlementInfoStatus("ACTIVE");

        public static readonly StackableEntitlementInfoStatus INACTIVE
            = new StackableEntitlementInfoStatus("INACTIVE");

        public static readonly StackableEntitlementInfoStatus CONSUMED
            = new StackableEntitlementInfoStatus("CONSUMED");

        public static readonly StackableEntitlementInfoStatus REVOKED
            = new StackableEntitlementInfoStatus("REVOKED");


        public static implicit operator StackableEntitlementInfoStatus(string value)
        {
            return Create(value);
        }

        public StackableEntitlementInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class StackableEntitlementInfoType : StringEnum<StackableEntitlementInfoType>
    {
        public static readonly StackableEntitlementInfoType DURABLE
            = new StackableEntitlementInfoType("DURABLE");

        public static readonly StackableEntitlementInfoType CONSUMABLE
            = new StackableEntitlementInfoType("CONSUMABLE");


        public static implicit operator StackableEntitlementInfoType(string value)
        {
            return Create(value);
        }

        public StackableEntitlementInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}