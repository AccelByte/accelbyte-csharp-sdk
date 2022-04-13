// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StoreInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonPropertyName("defaultRegion")]
        public string? DefaultRegion { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("published")]
        public bool? Published { get; set; }

        [JsonPropertyName("publishedTime")]
        public DateTime? PublishedTime { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

        [JsonPropertyName("supportedLanguages")]
        public List<string>? SupportedLanguages { get; set; }

        [JsonPropertyName("supportedRegions")]
        public List<string>? SupportedRegions { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }
}