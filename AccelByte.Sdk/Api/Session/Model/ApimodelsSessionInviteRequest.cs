// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsSessionInviteRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("platformID")]
        public string? PlatformID { get; set; }

        [JsonPropertyName("userID")]
        public string? UserID { get; set; }

    }


}