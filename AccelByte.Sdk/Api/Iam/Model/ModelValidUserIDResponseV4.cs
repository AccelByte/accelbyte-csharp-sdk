// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelValidUserIDResponseV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("exists")]
        public bool? Exists { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }
}