// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ValidationDescription : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("message")]
        public List<string>? Message { get; set; }
        
    }
}