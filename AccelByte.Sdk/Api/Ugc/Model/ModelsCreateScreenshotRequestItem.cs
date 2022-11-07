// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateScreenshotRequestItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("fileExtension")]
        [JsonStringEnum]
        public ModelsCreateScreenshotRequestItemFileExtension? FileExtension { get; set; }

    }

    public class ModelsCreateScreenshotRequestItemFileExtension : StringEnum<ModelsCreateScreenshotRequestItemFileExtension>
    {
        public static readonly ModelsCreateScreenshotRequestItemFileExtension Bmp
            = new ModelsCreateScreenshotRequestItemFileExtension("bmp");

        public static readonly ModelsCreateScreenshotRequestItemFileExtension Jfif
            = new ModelsCreateScreenshotRequestItemFileExtension("jfif");

        public static readonly ModelsCreateScreenshotRequestItemFileExtension Jpeg
            = new ModelsCreateScreenshotRequestItemFileExtension("jpeg");

        public static readonly ModelsCreateScreenshotRequestItemFileExtension Jpg
            = new ModelsCreateScreenshotRequestItemFileExtension("jpg");

        public static readonly ModelsCreateScreenshotRequestItemFileExtension Pjp
            = new ModelsCreateScreenshotRequestItemFileExtension("pjp");

        public static readonly ModelsCreateScreenshotRequestItemFileExtension Png
            = new ModelsCreateScreenshotRequestItemFileExtension("png");


        public static implicit operator ModelsCreateScreenshotRequestItemFileExtension(string value)
        {
            return NewValue(value);
        }

        public ModelsCreateScreenshotRequestItemFileExtension(string enumValue)
            : base(enumValue)
        {

        }
    }    
}