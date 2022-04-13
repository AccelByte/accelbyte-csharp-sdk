// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acquireOrderNo")]
        public string? AcquireOrderNo { get; set; }

        [JsonPropertyName("acquireUserId")]
        public string? AcquireUserId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("keyFile")]
        public string? KeyFile { get; set; }

        [JsonPropertyName("keyGroupId")]
        public string? KeyGroupId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public KeyInfoStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

    }

    public class KeyInfoStatus : StringEnum<KeyInfoStatus>
    {
        public static readonly KeyInfoStatus ACTIVE
            = new KeyInfoStatus("ACTIVE");

        public static readonly KeyInfoStatus ACQUIRED
            = new KeyInfoStatus("ACQUIRED");


        public static implicit operator KeyInfoStatus(string value)
        {
            return Create(value);
        }

        public KeyInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}