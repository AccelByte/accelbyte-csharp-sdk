// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserProfileAdmin : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("avatarLargeUrl")]
        public string? AvatarLargeUrl { get; set; }
        
        [JsonPropertyName("avatarSmallUrl")]
        public string? AvatarSmallUrl { get; set; }
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }
        
        [JsonPropertyName("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        
        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }
        
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
        
    }
}