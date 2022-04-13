// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUpgradeHeadlessAccountWithVerificationCodeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Code")]
        public string? Code { get; set; }

        [JsonPropertyName("Password")]
        public string? Password { get; set; }

        [JsonPropertyName("loginId")]
        public string? LoginId { get; set; }

    }
}