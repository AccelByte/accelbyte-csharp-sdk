// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountUserResponseV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authType")]
        public string? AuthType { get; set; }
        
        [JsonPropertyName("bans")]
        public List<AccountUserActiveBanResponseV4>? Bans { get; set; }
        
        [JsonPropertyName("country")]
        public string? Country { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        
        [JsonPropertyName("deletionStatus")]
        public bool? DeletionStatus { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("emailVerified")]
        public bool? EmailVerified { get; set; }
        
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        [JsonPropertyName("lastDateOfBirthChangedTime")]
        public DateTime? LastDateOfBirthChangedTime { get; set; }
        
        [JsonPropertyName("lastEnabledChangedTime")]
        public DateTime? LastEnabledChangedTime { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("newEmailAddress")]
        public string? NewEmailAddress { get; set; }
        
        [JsonPropertyName("oldEmailAddress")]
        public string? OldEmailAddress { get; set; }
        
        [JsonPropertyName("permissions")]
        public List<AccountUserPermissionsResponseV4>? Permissions { get; set; }
        
        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }
        
        [JsonPropertyName("phoneVerified")]
        public bool? PhoneVerified { get; set; }
        
        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }
        
        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("username")]
        public string? Username { get; set; }
        
    }
}