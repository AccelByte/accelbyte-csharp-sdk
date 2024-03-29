// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RequestHistory : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("requestTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RequestTime { get; set; }

        [JsonPropertyName("responseBody")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? ResponseBody { get; set; }

        [JsonPropertyName("responseTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ResponseTime { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RequestHistoryStatus? Status { get; set; }

        [JsonPropertyName("statusCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? StatusCode { get; set; }

    }

    public class RequestHistory<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("requestTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RequestTime { get; set; }

        [JsonPropertyName("responseBody")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? ResponseBody { get; set; }

        [JsonPropertyName("responseTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ResponseTime { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RequestHistoryStatus? Status { get; set; }

        [JsonPropertyName("statusCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? StatusCode { get; set; }

    }


    public class RequestHistoryStatus : StringEnum<RequestHistoryStatus>
    {
        public static readonly RequestHistoryStatus FAIL
            = new RequestHistoryStatus("FAIL");

        public static readonly RequestHistoryStatus PENDING
            = new RequestHistoryStatus("PENDING");

        public static readonly RequestHistoryStatus SUCCESS
            = new RequestHistoryStatus("SUCCESS");


        public static implicit operator RequestHistoryStatus(string value)
        {
            return NewValue(value);
        }

        public RequestHistoryStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}