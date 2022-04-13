// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class NotificationProcessResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("customParam")]
        public Dictionary<string, object>? CustomParam { get; set; }

        [JsonPropertyName("severity")]
        public int? Severity { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public NotificationProcessResultStatus? Status { get; set; }

    }

    public class NotificationProcessResultStatus : StringEnum<NotificationProcessResultStatus>
    {
        public static readonly NotificationProcessResultStatus PROCESSED
            = new NotificationProcessResultStatus("PROCESSED");

        public static readonly NotificationProcessResultStatus ERROR
            = new NotificationProcessResultStatus("ERROR");

        public static readonly NotificationProcessResultStatus WARN
            = new NotificationProcessResultStatus("WARN");

        public static readonly NotificationProcessResultStatus IGNORED
            = new NotificationProcessResultStatus("IGNORED");


        public static implicit operator NotificationProcessResultStatus(string value)
        {
            return Create(value);
        }

        public NotificationProcessResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}