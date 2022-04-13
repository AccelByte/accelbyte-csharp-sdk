// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SubscriptionActivityInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonStringEnum]
        public SubscriptionActivityInfoAction? Action { get; set; }

        [JsonPropertyName("chargedCycles")]
        public int? ChargedCycles { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("currentCycle")]
        public int? CurrentCycle { get; set; }

        [JsonPropertyName("grantDays")]
        public int? GrantDays { get; set; }

        [JsonPropertyName("inFixedCycleTrial")]
        public bool? InFixedCycleTrial { get; set; }

        [JsonPropertyName("inFixedFreeDays")]
        public bool? InFixedFreeDays { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("subscribedBy")]
        [JsonStringEnum]
        public SubscriptionActivityInfoSubscribedBy? SubscribedBy { get; set; }

        [JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("trialedCycles")]
        public int? TrialedCycles { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class SubscriptionActivityInfoAction : StringEnum<SubscriptionActivityInfoAction>
    {
        public static readonly SubscriptionActivityInfoAction SUBSCRIBE
            = new SubscriptionActivityInfoAction("SUBSCRIBE");

        public static readonly SubscriptionActivityInfoAction CANCEL
            = new SubscriptionActivityInfoAction("CANCEL");

        public static readonly SubscriptionActivityInfoAction IMMEDIATECANCEL
            = new SubscriptionActivityInfoAction("IMMEDIATE_CANCEL");

        public static readonly SubscriptionActivityInfoAction RESUBSCRIBE
            = new SubscriptionActivityInfoAction("RESUBSCRIBE");

        public static readonly SubscriptionActivityInfoAction GRANTDAYS
            = new SubscriptionActivityInfoAction("GRANT_DAYS");

        public static readonly SubscriptionActivityInfoAction CHANGEBILLINGACCOUNT
            = new SubscriptionActivityInfoAction("CHANGE_BILLING_ACCOUNT");


        public static implicit operator SubscriptionActivityInfoAction(string value)
        {
            return Create(value);
        }

        public SubscriptionActivityInfoAction(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class SubscriptionActivityInfoSubscribedBy : StringEnum<SubscriptionActivityInfoSubscribedBy>
    {
        public static readonly SubscriptionActivityInfoSubscribedBy USER
            = new SubscriptionActivityInfoSubscribedBy("USER");

        public static readonly SubscriptionActivityInfoSubscribedBy PLATFORM
            = new SubscriptionActivityInfoSubscribedBy("PLATFORM");


        public static implicit operator SubscriptionActivityInfoSubscribedBy(string value)
        {
            return Create(value);
        }

        public SubscriptionActivityInfoSubscribedBy(string enumValue)
            : base(enumValue)
        {

        }
    }    
}