// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ImportStoreError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errors")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ImportErrorDetails>? Errors { get; set; }

        [JsonPropertyName("item")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ImportStoreItemInfo? Item { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ImportStoreErrorType? Type { get; set; }

    }

    public class ImportStoreErrorType : StringEnum<ImportStoreErrorType>
    {
        public static readonly ImportStoreErrorType ITEM
            = new ImportStoreErrorType("ITEM");


        public static implicit operator ImportStoreErrorType(string value)
        {
            return NewValue(value);
        }

        public ImportStoreErrorType(string enumValue)
            : base(enumValue)
        {

        }
    }
}