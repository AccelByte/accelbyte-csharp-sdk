// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyGroupCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public KeyGroupCreateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

    }

    public class KeyGroupCreateStatus : StringEnum<KeyGroupCreateStatus>
    {
        public static readonly KeyGroupCreateStatus ACTIVE
            = new KeyGroupCreateStatus("ACTIVE");

        public static readonly KeyGroupCreateStatus INACTIVE
            = new KeyGroupCreateStatus("INACTIVE");


        public static implicit operator KeyGroupCreateStatus(string value)
        {
            return NewValue(value);
        }

        public KeyGroupCreateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}