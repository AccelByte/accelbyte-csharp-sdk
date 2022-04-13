// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("nullFieldList")]
        public List<string>? NullFieldList { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public EntitlementUpdateStatus? Status { get; set; }

        [JsonPropertyName("useCount")]
        public int? UseCount { get; set; }

    }

    public class EntitlementUpdateStatus : StringEnum<EntitlementUpdateStatus>
    {
        public static readonly EntitlementUpdateStatus ACTIVE
            = new EntitlementUpdateStatus("ACTIVE");

        public static readonly EntitlementUpdateStatus INACTIVE
            = new EntitlementUpdateStatus("INACTIVE");

        public static readonly EntitlementUpdateStatus CONSUMED
            = new EntitlementUpdateStatus("CONSUMED");

        public static readonly EntitlementUpdateStatus REVOKED
            = new EntitlementUpdateStatus("REVOKED");


        public static implicit operator EntitlementUpdateStatus(string value)
        {
            return Create(value);
        }

        public EntitlementUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}