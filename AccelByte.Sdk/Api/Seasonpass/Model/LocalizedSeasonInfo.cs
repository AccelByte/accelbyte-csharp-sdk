// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class LocalizedSeasonInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("autoClaim")]
        public bool? AutoClaim { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("end")]
        public DateTime? End { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("passCodes")]
        public List<string>? PassCodes { get; set; }

        [JsonPropertyName("passes")]
        public List<LocalizedPassInfo>? Passes { get; set; }

        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }

        [JsonPropertyName("rewards")]
        public Dictionary<string, RewardInfo>? Rewards { get; set; }

        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public LocalizedSeasonInfoStatus? Status { get; set; }

        [JsonPropertyName("tierItemId")]
        public string? TierItemId { get; set; }

        [JsonPropertyName("tiers")]
        public List<Tier>? Tiers { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class LocalizedSeasonInfoStatus : StringEnum<LocalizedSeasonInfoStatus>
    {
        public static readonly LocalizedSeasonInfoStatus DRAFT
            = new LocalizedSeasonInfoStatus("DRAFT");

        public static readonly LocalizedSeasonInfoStatus PUBLISHED
            = new LocalizedSeasonInfoStatus("PUBLISHED");

        public static readonly LocalizedSeasonInfoStatus RETIRED
            = new LocalizedSeasonInfoStatus("RETIRED");


        public static implicit operator LocalizedSeasonInfoStatus(string value)
        {
            return Create(value);
        }

        public LocalizedSeasonInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}