// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserCreateRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("PasswordMD5Sum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PasswordMD5Sum { get; set; }

        [JsonPropertyName("acceptedPolicies")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<LegalAcceptedPoliciesRequest>? AcceptedPolicies { get; set; }

        [JsonPropertyName("authType")]
        public string? AuthType { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("dateOfBirth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DateOfBirth { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("reachMinimumAge")]
        public bool? ReachMinimumAge { get; set; }

        [JsonPropertyName("uniqueDisplayName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UniqueDisplayName { get; set; }

    }


}