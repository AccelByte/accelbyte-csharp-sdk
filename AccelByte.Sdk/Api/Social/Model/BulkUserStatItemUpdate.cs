// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkUserStatItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<string, object>? AdditionalData { get; set; }

        [JsonPropertyName("additionalKey")]
        public string? AdditionalKey { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

        [JsonPropertyName("updateStrategy")]
        [JsonStringEnum]
        public BulkUserStatItemUpdateUpdateStrategy? UpdateStrategy { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }

    }

    public class BulkUserStatItemUpdateUpdateStrategy : StringEnum<BulkUserStatItemUpdateUpdateStrategy>
    {
        public static readonly BulkUserStatItemUpdateUpdateStrategy OVERRIDE
            = new BulkUserStatItemUpdateUpdateStrategy("OVERRIDE");

        public static readonly BulkUserStatItemUpdateUpdateStrategy INCREMENT
            = new BulkUserStatItemUpdateUpdateStrategy("INCREMENT");

        public static readonly BulkUserStatItemUpdateUpdateStrategy MAX
            = new BulkUserStatItemUpdateUpdateStrategy("MAX");

        public static readonly BulkUserStatItemUpdateUpdateStrategy MIN
            = new BulkUserStatItemUpdateUpdateStrategy("MIN");


        public static implicit operator BulkUserStatItemUpdateUpdateStrategy(string value)
        {
            return Create(value);
        }

        public BulkUserStatItemUpdateUpdateStrategy(string enumValue)
            : base(enumValue)
        {

        }
    }    
}