// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelTokenIntrospectResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
        
        [JsonPropertyName("aud")]
        public string? Aud { get; set; }
        
        [JsonPropertyName("client_id")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("exp")]
        public long? Exp { get; set; }
        
        [JsonPropertyName("iat")]
        public long? Iat { get; set; }
        
        [JsonPropertyName("scope")]
        public string? Scope { get; set; }
        
        [JsonPropertyName("sub")]
        public string? Sub { get; set; }
        
    }
}