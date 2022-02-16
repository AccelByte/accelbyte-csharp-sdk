// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthcommonJWKSet : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("keys")]
        public List<OauthcommonJWKKey>? Keys { get; set; }
        
    }
}