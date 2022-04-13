// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSendVerificationCodeRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("context")]
        public string? Context { get; set; }

        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("languageTag")]
        public string? LanguageTag { get; set; }

    }
}