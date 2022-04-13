// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonStringEnum]
        public EntitlementHistoryInfoAction? Action { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("entitlementId")]
        public string? EntitlementId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class EntitlementHistoryInfoAction : StringEnum<EntitlementHistoryInfoAction>
    {
        public static readonly EntitlementHistoryInfoAction GRANT
            = new EntitlementHistoryInfoAction("GRANT");

        public static readonly EntitlementHistoryInfoAction UPDATE
            = new EntitlementHistoryInfoAction("UPDATE");

        public static readonly EntitlementHistoryInfoAction DECREMENT
            = new EntitlementHistoryInfoAction("DECREMENT");

        public static readonly EntitlementHistoryInfoAction REVOKE
            = new EntitlementHistoryInfoAction("REVOKE");

        public static readonly EntitlementHistoryInfoAction DISABLE
            = new EntitlementHistoryInfoAction("DISABLE");

        public static readonly EntitlementHistoryInfoAction ENABLE
            = new EntitlementHistoryInfoAction("ENABLE");


        public static implicit operator EntitlementHistoryInfoAction(string value)
        {
            return Create(value);
        }

        public EntitlementHistoryInfoAction(string enumValue)
            : base(enumValue)
        {

        }
    }    
}