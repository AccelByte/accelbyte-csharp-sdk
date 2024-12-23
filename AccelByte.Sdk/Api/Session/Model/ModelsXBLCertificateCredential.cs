// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ModelsXBLCertificateCredential : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("businessPartnerCertFileBytes")]
        public string? BusinessPartnerCertFileBytes { get; set; }

        [JsonPropertyName("businessPartnerCertFileName")]
        public string? BusinessPartnerCertFileName { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }


}