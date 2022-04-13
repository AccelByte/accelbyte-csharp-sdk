// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class UpdatePolicyVersionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("displayVersion")]
        public string? DisplayVersion { get; set; }

        [JsonPropertyName("isCommitted")]
        public bool? IsCommitted { get; set; }

    }
}