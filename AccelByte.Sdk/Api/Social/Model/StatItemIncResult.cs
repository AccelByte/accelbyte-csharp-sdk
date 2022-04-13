// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatItemIncResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentValue")]
        public double? CurrentValue { get; set; }

    }
}