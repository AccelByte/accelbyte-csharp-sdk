// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelErrorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }
        
        [JsonPropertyName("error_description")]
        public string? ErrorDescription { get; set; }
        
        [JsonPropertyName("error_uri")]
        public string? ErrorUri { get; set; }
        
    }
}