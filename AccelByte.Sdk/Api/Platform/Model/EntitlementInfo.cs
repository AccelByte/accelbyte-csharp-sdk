// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public EntitlementInfoAppType? AppType { get; set; }

        [JsonPropertyName("clazz")]
        [JsonStringEnum]
        public EntitlementInfoClazz? Clazz { get; set; }

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
        public EntitlementInfoSource? Source { get; set; }

        [JsonPropertyName("stackable")]
        public bool? Stackable { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public EntitlementInfoStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public EntitlementInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class EntitlementInfoAppType : StringEnum<EntitlementInfoAppType>
    {
        public static readonly EntitlementInfoAppType GAME
            = new EntitlementInfoAppType("GAME");

        public static readonly EntitlementInfoAppType SOFTWARE
            = new EntitlementInfoAppType("SOFTWARE");

        public static readonly EntitlementInfoAppType DLC
            = new EntitlementInfoAppType("DLC");

        public static readonly EntitlementInfoAppType DEMO
            = new EntitlementInfoAppType("DEMO");


        public static implicit operator EntitlementInfoAppType(string value)
        {
            return Create(value);
        }

        public EntitlementInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class EntitlementInfoClazz : StringEnum<EntitlementInfoClazz>
    {
        public static readonly EntitlementInfoClazz APP
            = new EntitlementInfoClazz("APP");

        public static readonly EntitlementInfoClazz ENTITLEMENT
            = new EntitlementInfoClazz("ENTITLEMENT");

        public static readonly EntitlementInfoClazz CODE
            = new EntitlementInfoClazz("CODE");

        public static readonly EntitlementInfoClazz SUBSCRIPTION
            = new EntitlementInfoClazz("SUBSCRIPTION");

        public static readonly EntitlementInfoClazz MEDIA
            = new EntitlementInfoClazz("MEDIA");


        public static implicit operator EntitlementInfoClazz(string value)
        {
            return Create(value);
        }

        public EntitlementInfoClazz(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class EntitlementInfoSource : StringEnum<EntitlementInfoSource>
    {
        public static readonly EntitlementInfoSource PURCHASE
            = new EntitlementInfoSource("PURCHASE");

        public static readonly EntitlementInfoSource IAP
            = new EntitlementInfoSource("IAP");

        public static readonly EntitlementInfoSource PROMOTION
            = new EntitlementInfoSource("PROMOTION");

        public static readonly EntitlementInfoSource ACHIEVEMENT
            = new EntitlementInfoSource("ACHIEVEMENT");

        public static readonly EntitlementInfoSource REFERRALBONUS
            = new EntitlementInfoSource("REFERRAL_BONUS");

        public static readonly EntitlementInfoSource REDEEMCODE
            = new EntitlementInfoSource("REDEEM_CODE");

        public static readonly EntitlementInfoSource REWARD
            = new EntitlementInfoSource("REWARD");

        public static readonly EntitlementInfoSource GIFT
            = new EntitlementInfoSource("GIFT");

        public static readonly EntitlementInfoSource OTHER
            = new EntitlementInfoSource("OTHER");


        public static implicit operator EntitlementInfoSource(string value)
        {
            return Create(value);
        }

        public EntitlementInfoSource(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class EntitlementInfoStatus : StringEnum<EntitlementInfoStatus>
    {
        public static readonly EntitlementInfoStatus ACTIVE
            = new EntitlementInfoStatus("ACTIVE");

        public static readonly EntitlementInfoStatus INACTIVE
            = new EntitlementInfoStatus("INACTIVE");

        public static readonly EntitlementInfoStatus CONSUMED
            = new EntitlementInfoStatus("CONSUMED");

        public static readonly EntitlementInfoStatus REVOKED
            = new EntitlementInfoStatus("REVOKED");


        public static implicit operator EntitlementInfoStatus(string value)
        {
            return Create(value);
        }

        public EntitlementInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class EntitlementInfoType : StringEnum<EntitlementInfoType>
    {
        public static readonly EntitlementInfoType DURABLE
            = new EntitlementInfoType("DURABLE");

        public static readonly EntitlementInfoType CONSUMABLE
            = new EntitlementInfoType("CONSUMABLE");


        public static implicit operator EntitlementInfoType(string value)
        {
            return Create(value);
        }

        public EntitlementInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}