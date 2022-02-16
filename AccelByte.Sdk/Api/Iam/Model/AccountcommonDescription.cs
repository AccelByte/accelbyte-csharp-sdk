// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonDescription : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("en-US")]
        public string? EnUS { get; set; }
        
        [JsonPropertyName("zh-CN")]
        public string? ZhCN { get; set; }
        
    }
}