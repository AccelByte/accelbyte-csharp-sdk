// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsPlayerBinaryRecordCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        [JsonPropertyName("is_public")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPublic { get; set; }

        [JsonPropertyName("key")]
        public string? Key { get; set; }

        [JsonPropertyName("set_by")]
        [JsonStringEnum]
        public ModelsPlayerBinaryRecordCreateSetBy? SetBy { get; set; }

    }



    public class ModelsPlayerBinaryRecordCreateSetBy : StringEnum<ModelsPlayerBinaryRecordCreateSetBy>
    {
        public static readonly ModelsPlayerBinaryRecordCreateSetBy CLIENT
            = new ModelsPlayerBinaryRecordCreateSetBy("CLIENT");

        public static readonly ModelsPlayerBinaryRecordCreateSetBy SERVER
            = new ModelsPlayerBinaryRecordCreateSetBy("SERVER");


        public static implicit operator ModelsPlayerBinaryRecordCreateSetBy(string value)
        {
            return NewValue(value);
        }

        public ModelsPlayerBinaryRecordCreateSetBy(string enumValue)
            : base(enumValue)
        {

        }
    }
}