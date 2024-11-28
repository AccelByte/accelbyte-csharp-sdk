// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreatePolicyRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("countries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Countries { get; set; }

        [JsonPropertyName("countryCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryCode { get; set; }

        [JsonPropertyName("countryGroupName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CountryGroupName { get; set; }

        [JsonPropertyName("countryType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CreatePolicyRequestCountryType? CountryType { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("isDefaultSelection")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsDefaultSelection { get; set; }

        [JsonPropertyName("isMandatory")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("policyName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PolicyName { get; set; }

        [JsonPropertyName("shouldNotifyOnUpdate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ShouldNotifyOnUpdate { get; set; }

    }



    public class CreatePolicyRequestCountryType : StringEnum<CreatePolicyRequestCountryType>
    {
        public static readonly CreatePolicyRequestCountryType COUNTRY
            = new CreatePolicyRequestCountryType("COUNTRY");

        public static readonly CreatePolicyRequestCountryType COUNTRYGROUP
            = new CreatePolicyRequestCountryType("COUNTRY_GROUP");


        public static implicit operator CreatePolicyRequestCountryType(string value)
        {
            return NewValue(value);
        }

        public CreatePolicyRequestCountryType(string enumValue)
            : base(enumValue)
        {

        }
    }
}