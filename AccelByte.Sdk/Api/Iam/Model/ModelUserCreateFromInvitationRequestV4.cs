// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserCreateFromInvitationRequestV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acceptedPolicies")]
        public List<LegalAcceptedPoliciesRequest>? AcceptedPolicies { get; set; }

        [JsonPropertyName("authType")]
        [JsonStringEnum]
        public ModelUserCreateFromInvitationRequestV4AuthType? AuthType { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public string? DateOfBirth { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("reachMinimumAge")]
        public bool? ReachMinimumAge { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }

    }

    public class ModelUserCreateFromInvitationRequestV4AuthType : StringEnum<ModelUserCreateFromInvitationRequestV4AuthType>
    {
        public static readonly ModelUserCreateFromInvitationRequestV4AuthType EMAILPASSWD
            = new ModelUserCreateFromInvitationRequestV4AuthType("EMAILPASSWD");


        public static implicit operator ModelUserCreateFromInvitationRequestV4AuthType(string value)
        {
            return NewValue(value);
        }

        public ModelUserCreateFromInvitationRequestV4AuthType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}