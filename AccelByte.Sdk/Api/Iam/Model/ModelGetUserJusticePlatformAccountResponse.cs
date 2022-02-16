// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetUserJusticePlatformAccountResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DesignatedNamespace")]
        public string? DesignatedNamespace { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}