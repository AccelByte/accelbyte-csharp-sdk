// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class BulkStatItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<string, object>? AdditionalData { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

        [JsonPropertyName("updateStrategy")]
        [JsonStringEnum]
        public BulkStatItemUpdateUpdateStrategy? UpdateStrategy { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }

    }

    public class BulkStatItemUpdateUpdateStrategy : StringEnum<BulkStatItemUpdateUpdateStrategy>
    {
        public static readonly BulkStatItemUpdateUpdateStrategy OVERRIDE
            = new BulkStatItemUpdateUpdateStrategy("OVERRIDE");

        public static readonly BulkStatItemUpdateUpdateStrategy INCREMENT
            = new BulkStatItemUpdateUpdateStrategy("INCREMENT");

        public static readonly BulkStatItemUpdateUpdateStrategy MAX
            = new BulkStatItemUpdateUpdateStrategy("MAX");

        public static readonly BulkStatItemUpdateUpdateStrategy MIN
            = new BulkStatItemUpdateUpdateStrategy("MIN");


        public static implicit operator BulkStatItemUpdateUpdateStrategy(string value)
        {
            return Create(value);
        }

        public BulkStatItemUpdateUpdateStrategy(string enumValue)
            : base(enumValue)
        {

        }
    }    
}