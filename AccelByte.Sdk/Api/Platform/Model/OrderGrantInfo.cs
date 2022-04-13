// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderGrantInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("credits")]
        public List<CreditSummary>? Credits { get; set; }

        [JsonPropertyName("entitlements")]
        public List<EntitlementSummary>? Entitlements { get; set; }

    }
}