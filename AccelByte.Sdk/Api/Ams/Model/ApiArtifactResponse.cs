// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiArtifactResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("artifactType")]
        public string? ArtifactType { get; set; }

        [JsonPropertyName("createdOn")]
        public ApiTime? CreatedOn { get; set; }

        [JsonPropertyName("dsId")]
        public string? DsId { get; set; }

        [JsonPropertyName("expiresOn")]
        public ApiTime? ExpiresOn { get; set; }

        [JsonPropertyName("fleetId")]
        public string? FleetId { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("imageId")]
        public string? ImageId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("sizeBytes")]
        public int? SizeBytes { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("storagePath")]
        public string? StoragePath { get; set; }

    }


}