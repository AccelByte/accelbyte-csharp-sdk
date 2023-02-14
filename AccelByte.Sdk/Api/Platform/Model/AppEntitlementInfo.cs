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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AppEntitlementInfoAppType? AppType { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("grantedAt")]
        public DateTime? GrantedAt { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSnapshot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public AppEntitlementInfoStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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