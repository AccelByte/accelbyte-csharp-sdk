// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ConsumableEntitlementRevocationConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Enabled { get; set; }

        [JsonPropertyName("strategy")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ConsumableEntitlementRevocationConfigStrategy? Strategy { get; set; }

    }



    public class ConsumableEntitlementRevocationConfigStrategy : StringEnum<ConsumableEntitlementRevocationConfigStrategy>
    {
        public static readonly ConsumableEntitlementRevocationConfigStrategy CUSTOM
            = new ConsumableEntitlementRevocationConfigStrategy("CUSTOM");

        public static readonly ConsumableEntitlementRevocationConfigStrategy REVOKEORREPORT
            = new ConsumableEntitlementRevocationConfigStrategy("REVOKE_OR_REPORT");


        public static implicit operator ConsumableEntitlementRevocationConfigStrategy(string value)
        {
            return NewValue(value);
        }

        public ConsumableEntitlementRevocationConfigStrategy(string enumValue)
            : base(enumValue)
        {

        }
    }
}