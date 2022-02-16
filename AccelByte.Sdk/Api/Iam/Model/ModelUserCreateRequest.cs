// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserCreateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AuthType")]
        public string? AuthType { get; set; }
        
        [JsonPropertyName("Country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("LoginId")]
        public string? LoginId { get; set; }
        
        [JsonPropertyName("Password")]
        public string? Password { get; set; }
        
        [JsonPropertyName("PasswordMD5Sum")]
        public string? PasswordMD5Sum { get; set; }
        
    }
}