// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserProfileStatusUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        [JsonStringEnum]
        public UserProfileStatusUpdateStatus? Status { get; set; }

    }

    public class UserProfileStatusUpdateStatus : StringEnum<UserProfileStatusUpdateStatus>
    {
        public static readonly UserProfileStatusUpdateStatus ACTIVE
            = new UserProfileStatusUpdateStatus("ACTIVE");

        public static readonly UserProfileStatusUpdateStatus INACTIVE
            = new UserProfileStatusUpdateStatus("INACTIVE");


        public static implicit operator UserProfileStatusUpdateStatus(string value)
        {
            return Create(value);
        }

        public UserProfileStatusUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}