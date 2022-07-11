// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonNetflixCertificates : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("encryptedPrivateKey")]
        public string? EncryptedPrivateKey { get; set; }

        [JsonPropertyName("encryptedPrivateKeyName")]
        public string? EncryptedPrivateKeyName { get; set; }

        [JsonPropertyName("publicCertificate")]
        public string? PublicCertificate { get; set; }

        [JsonPropertyName("publicCertificateName")]
        public string? PublicCertificateName { get; set; }

        [JsonPropertyName("rootCertificate")]
        public string? RootCertificate { get; set; }

        [JsonPropertyName("rootCertificateName")]
        public string? RootCertificateName { get; set; }

    }
}