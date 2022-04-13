// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ListSeasonInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonPropertyName("end")]
        public DateTime? End { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("passCodes")]
        public List<string>? PassCodes { get; set; }

        [JsonPropertyName("publishedAt")]
        public DateTime? PublishedAt { get; set; }

        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ListSeasonInfoStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class ListSeasonInfoStatus : StringEnum<ListSeasonInfoStatus>
    {
        public static readonly ListSeasonInfoStatus DRAFT
            = new ListSeasonInfoStatus("DRAFT");

        public static readonly ListSeasonInfoStatus PUBLISHED
            = new ListSeasonInfoStatus("PUBLISHED");

        public static readonly ListSeasonInfoStatus RETIRED
            = new ListSeasonInfoStatus("RETIRED");


        public static implicit operator ListSeasonInfoStatus(string value)
        {
            return Create(value);
        }

        public ListSeasonInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}