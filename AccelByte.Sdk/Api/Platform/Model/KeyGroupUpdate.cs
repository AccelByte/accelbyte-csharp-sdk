// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyGroupUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public KeyGroupUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

    }

    public class KeyGroupUpdateStatus : StringEnum<KeyGroupUpdateStatus>
    {
        public static readonly KeyGroupUpdateStatus ACTIVE
            = new KeyGroupUpdateStatus("ACTIVE");

        public static readonly KeyGroupUpdateStatus INACTIVE
            = new KeyGroupUpdateStatus("INACTIVE");


        public static implicit operator KeyGroupUpdateStatus(string value)
        {
            return Create(value);
        }

        public KeyGroupUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}