// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UploadPolicyVersionAttachmentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentMD5")]
        public string? ContentMD5 { get; set; }
        
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
    }
}