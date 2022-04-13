// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("grantDays")]
        public string? GrantDays { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

    }
}