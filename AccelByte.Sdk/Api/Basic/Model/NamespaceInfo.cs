// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class NamespaceInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public NamespaceInfoStatus? Status { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class NamespaceInfoStatus : StringEnum<NamespaceInfoStatus>
    {
        public static readonly NamespaceInfoStatus ACTIVE
            = new NamespaceInfoStatus("ACTIVE");

        public static readonly NamespaceInfoStatus INACTIVE
            = new NamespaceInfoStatus("INACTIVE");

        public static readonly NamespaceInfoStatus DELETED
            = new NamespaceInfoStatus("DELETED");


        public static implicit operator NamespaceInfoStatus(string value)
        {
            return NewValue(value);
        }

        public NamespaceInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}