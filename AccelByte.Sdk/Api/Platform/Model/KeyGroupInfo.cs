// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyGroupInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("boothName")]
        public string? BoothName { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public KeyGroupInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class KeyGroupInfoStatus : StringEnum<KeyGroupInfoStatus>
    {
        public static readonly KeyGroupInfoStatus ACTIVE
            = new KeyGroupInfoStatus("ACTIVE");

        public static readonly KeyGroupInfoStatus INACTIVE
            = new KeyGroupInfoStatus("INACTIVE");


        public static implicit operator KeyGroupInfoStatus(string value)
        {
            return Create(value);
        }

        public KeyGroupInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}