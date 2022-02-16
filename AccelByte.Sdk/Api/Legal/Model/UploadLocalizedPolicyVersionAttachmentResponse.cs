// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UploadLocalizedPolicyVersionAttachmentResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attachmentChecksum")]
        public string? AttachmentChecksum { get; set; }
        
        [JsonPropertyName("attachmentLocation")]
        public string? AttachmentLocation { get; set; }
        
        [JsonPropertyName("attachmentUploadUrl")]
        public string? AttachmentUploadUrl { get; set; }
        
    }
}