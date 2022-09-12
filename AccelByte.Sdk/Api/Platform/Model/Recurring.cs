// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Recurring : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cycle")]
        [JsonStringEnum]
        public RecurringCycle? Cycle { get; set; }

        [JsonPropertyName("fixedFreeDays")]
        public int? FixedFreeDays { get; set; }

        [JsonPropertyName("fixedTrialCycles")]
        public int? FixedTrialCycles { get; set; }

        [JsonPropertyName("graceDays")]
        public int? GraceDays { get; set; }

    }

    public class RecurringCycle : StringEnum<RecurringCycle>
    {
        public static readonly RecurringCycle MONTHLY
            = new RecurringCycle("MONTHLY");

        public static readonly RecurringCycle QUARTERLY
            = new RecurringCycle("QUARTERLY");

        public static readonly RecurringCycle WEEKLY
            = new RecurringCycle("WEEKLY");

        public static readonly RecurringCycle YEARLY
            = new RecurringCycle("YEARLY");


        public static implicit operator RecurringCycle(string value)
        {
            return NewValue(value);
        }

        public RecurringCycle(string enumValue)
            : base(enumValue)
        {

        }
    }
}