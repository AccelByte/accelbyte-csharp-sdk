// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ErrorEntity : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("devStackTrace")]
        public string? DevStackTrace { get; set; }

        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("messageVariables")]
        public Dictionary<string, string>? MessageVariables { get; set; }

    }
}