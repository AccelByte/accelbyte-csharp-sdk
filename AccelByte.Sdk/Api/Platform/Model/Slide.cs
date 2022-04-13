// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Slide : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alt")]
        public string? Alt { get; set; }

        [JsonPropertyName("previewUrl")]
        public string? PreviewUrl { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public SlideType? Type { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("videoSource")]
        [JsonStringEnum]
        public SlideVideoSource? VideoSource { get; set; }

    }

    public class SlideType : StringEnum<SlideType>
    {
        public static readonly SlideType Image
            = new SlideType("image");

        public static readonly SlideType Video
            = new SlideType("video");


        public static implicit operator SlideType(string value)
        {
            return Create(value);
        }

        public SlideType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class SlideVideoSource : StringEnum<SlideVideoSource>
    {
        public static readonly SlideVideoSource Generic
            = new SlideVideoSource("generic");

        public static readonly SlideVideoSource Youtube
            = new SlideVideoSource("youtube");

        public static readonly SlideVideoSource Vimeo
            = new SlideVideoSource("vimeo");


        public static implicit operator SlideVideoSource(string value)
        {
            return Create(value);
        }

        public SlideVideoSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}