// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelTokenThirdPartyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platform_token")]
        public string? PlatformToken { get; set; }
        
        [JsonPropertyName("sand_box_id")]
        public string? SandBoxId { get; set; }
        
    }
}