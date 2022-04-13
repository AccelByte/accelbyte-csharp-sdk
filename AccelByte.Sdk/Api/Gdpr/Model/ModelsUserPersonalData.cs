// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class ModelsUserPersonalData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DataExpirationDate")]
        public DateTime? DataExpirationDate { get; set; }

        [JsonPropertyName("RequestDate")]
        public DateTime? RequestDate { get; set; }

        [JsonPropertyName("Status")]
        public string? Status { get; set; }

    }
}