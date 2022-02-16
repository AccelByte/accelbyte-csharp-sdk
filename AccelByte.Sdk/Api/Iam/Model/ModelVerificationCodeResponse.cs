// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelVerificationCodeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("accountRegistration")]
        public string? AccountRegistration { get; set; }
        
        [JsonPropertyName("accountUpgrade")]
        public string? AccountUpgrade { get; set; }
        
        [JsonPropertyName("passwordReset")]
        public string? PasswordReset { get; set; }
        
        [JsonPropertyName("updateEmail")]
        public string? UpdateEmail { get; set; }
        
    }
}