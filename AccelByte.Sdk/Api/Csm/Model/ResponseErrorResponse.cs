// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Csm.Model
{
    public class ResponseErrorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("errors")]
        public string? Errors { get; set; }

        [JsonPropertyName("messageVariables")]
        public Dictionary<string, string>? MessageVariables { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

    }


}