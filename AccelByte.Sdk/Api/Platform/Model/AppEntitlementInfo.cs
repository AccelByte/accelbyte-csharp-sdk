// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppEntitlementInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonStringEnum]
        public AppEntitlementInfoAppType? AppType { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("grantedAt")]
        public DateTime? GrantedAt { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSnapshot")]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public AppEntitlementInfoStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class AppEntitlementInfoAppType : StringEnum<AppEntitlementInfoAppType>
    {
        public static readonly AppEntitlementInfoAppType DEMO
            = new AppEntitlementInfoAppType("DEMO");

        public static readonly AppEntitlementInfoAppType DLC
            = new AppEntitlementInfoAppType("DLC");

        public static readonly AppEntitlementInfoAppType GAME
            = new AppEntitlementInfoAppType("GAME");

        public static readonly AppEntitlementInfoAppType SOFTWARE
            = new AppEntitlementInfoAppType("SOFTWARE");


        public static implicit operator AppEntitlementInfoAppType(string value)
        {
            return NewValue(value);
        }

        public AppEntitlementInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppEntitlementInfoStatus : StringEnum<AppEntitlementInfoStatus>
    {
        public static readonly AppEntitlementInfoStatus ACTIVE
            = new AppEntitlementInfoStatus("ACTIVE");

        public static readonly AppEntitlementInfoStatus CONSUMED
            = new AppEntitlementInfoStatus("CONSUMED");

        public static readonly AppEntitlementInfoStatus INACTIVE
            = new AppEntitlementInfoStatus("INACTIVE");

        public static readonly AppEntitlementInfoStatus REVOKED
            = new AppEntitlementInfoStatus("REVOKED");


        public static implicit operator AppEntitlementInfoStatus(string value)
        {
            return NewValue(value);
        }

        public AppEntitlementInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}