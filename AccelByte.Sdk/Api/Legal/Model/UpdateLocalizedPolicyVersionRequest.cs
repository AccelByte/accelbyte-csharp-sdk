// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UpdateLocalizedPolicyVersionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attachmentChecksum")]
        public string? AttachmentChecksum { get; set; }
        
        [JsonPropertyName("attachmentLocation")]
        public string? AttachmentLocation { get; set; }
        
        [JsonPropertyName("attachmentVersionIdentifier")]
        public string? AttachmentVersionIdentifier { get; set; }
        
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
    }
}