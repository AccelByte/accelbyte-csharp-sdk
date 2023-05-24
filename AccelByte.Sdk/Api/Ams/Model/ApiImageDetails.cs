// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiImageDetails : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isProtected")]
        public bool? IsProtected { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("referencingFleets")]
        public List<ApiReferencingFleet>? ReferencingFleets { get; set; }

        [JsonPropertyName("sizeInByte")]
        public long? SizeInByte { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("uploadedAt")]
        public DateTime? UploadedAt { get; set; }

        [JsonPropertyName("uploadedBy")]
        public string? UploadedBy { get; set; }

    }


}