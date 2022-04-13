// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Image : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("as")]
        public string? As { get; set; }

        [JsonPropertyName("caption")]
        public string? Caption { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        [JsonPropertyName("smallImageUrl")]
        public string? SmallImageUrl { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

    }
}