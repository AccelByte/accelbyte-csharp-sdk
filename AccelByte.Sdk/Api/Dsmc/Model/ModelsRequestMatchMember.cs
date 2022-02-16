// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsRequestMatchMember : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}