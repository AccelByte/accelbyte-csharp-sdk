// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelBackupCodesResponseV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("generatedAt")]
        public long? GeneratedAt { get; set; }
        
        [JsonPropertyName("invalidCodes")]
        public List<string>? InvalidCodes { get; set; }
        
        [JsonPropertyName("validCodes")]
        public List<string>? ValidCodes { get; set; }
        
    }
}