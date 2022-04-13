// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserProfileInfo : AccelByte.Sdk.Core.Model
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
        [JsonDateTimeConverter("yyyy-MM-dd")]
        public DateTime? DateOfBirth { get; set; }

        [JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public UserProfileInfoStatus? Status { get; set; }

        [JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }

    }

    public class UserProfileInfoStatus : StringEnum<UserProfileInfoStatus>
    {
        public static readonly UserProfileInfoStatus ACTIVE
            = new UserProfileInfoStatus("ACTIVE");

        public static readonly UserProfileInfoStatus INACTIVE
            = new UserProfileInfoStatus("INACTIVE");


        public static implicit operator UserProfileInfoStatus(string value)
        {
            return Create(value);
        }

        public UserProfileInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}