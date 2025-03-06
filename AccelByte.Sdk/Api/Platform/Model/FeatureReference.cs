// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FeatureReference : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("feature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FeatureReferenceFeature? Feature { get; set; }

        [JsonPropertyName("references")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModuleReference>? References { get; set; }

    }



    public class FeatureReferenceFeature : StringEnum<FeatureReferenceFeature>
    {
        public static readonly FeatureReferenceFeature CAMPAIGN
            = new FeatureReferenceFeature("CAMPAIGN");

        public static readonly FeatureReferenceFeature CATALOG
            = new FeatureReferenceFeature("CATALOG");

        public static readonly FeatureReferenceFeature DLC
            = new FeatureReferenceFeature("DLC");

        public static readonly FeatureReferenceFeature ENTITLEMENT
            = new FeatureReferenceFeature("ENTITLEMENT");

        public static readonly FeatureReferenceFeature IAP
            = new FeatureReferenceFeature("IAP");

        public static readonly FeatureReferenceFeature REWARD
            = new FeatureReferenceFeature("REWARD");


        public static implicit operator FeatureReferenceFeature(string value)
        {
            return NewValue(value);
        }

        public FeatureReferenceFeature(string enumValue)
            : base(enumValue)
        {

        }
    }
}