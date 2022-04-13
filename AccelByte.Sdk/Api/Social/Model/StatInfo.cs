// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("defaultValue")]
        public double? DefaultValue { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("incrementOnly")]
        public bool? IncrementOnly { get; set; }

        [JsonPropertyName("maximum")]
        public double? Maximum { get; set; }

        [JsonPropertyName("minimum")]
        public double? Minimum { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("setAsGlobal")]
        public bool? SetAsGlobal { get; set; }

        [JsonPropertyName("setBy")]
        [JsonStringEnum]
        public StatInfoSetBy? SetBy { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public StatInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class StatInfoSetBy : StringEnum<StatInfoSetBy>
    {
        public static readonly StatInfoSetBy CLIENT
            = new StatInfoSetBy("CLIENT");

        public static readonly StatInfoSetBy SERVER
            = new StatInfoSetBy("SERVER");


        public static implicit operator StatInfoSetBy(string value)
        {
            return Create(value);
        }

        public StatInfoSetBy(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class StatInfoStatus : StringEnum<StatInfoStatus>
    {
        public static readonly StatInfoStatus INIT
            = new StatInfoStatus("INIT");

        public static readonly StatInfoStatus TIED
            = new StatInfoStatus("TIED");


        public static implicit operator StatInfoStatus(string value)
        {
            return Create(value);
        }

        public StatInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}