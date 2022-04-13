// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class SeasonUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("autoClaim")]
        public bool? AutoClaim { get; set; }

        [JsonPropertyName("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonPropertyName("defaultRequiredExp")]
        public int? DefaultRequiredExp { get; set; }

        [JsonPropertyName("draftStoreId")]
        public string? DraftStoreId { get; set; }

        [JsonPropertyName("end")]
        public DateTime? End { get; set; }

        [JsonPropertyName("excessStrategy")]
        public ExcessStrategy? ExcessStrategy { get; set; }

        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }

        [JsonPropertyName("tierItemId")]
        public string? TierItemId { get; set; }

    }
}