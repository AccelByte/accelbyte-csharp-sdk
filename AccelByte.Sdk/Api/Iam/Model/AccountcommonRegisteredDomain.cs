// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonRegisteredDomain : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIDs")]
        public List<string>? AffectedClientIDs { get; set; }
        
        [JsonPropertyName("domain")]
        public string? Domain { get; set; }
        
        [JsonPropertyName("namespaces")]
        public List<string>? Namespaces { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
    }
}