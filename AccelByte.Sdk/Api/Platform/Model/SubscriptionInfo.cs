// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SubscriptionInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("billingAccount")]
        public BillingAccount? BillingAccount { get; set; }

        [JsonPropertyName("chargeStatus")]
        [JsonStringEnum]
        public SubscriptionInfoChargeStatus? ChargeStatus { get; set; }

        [JsonPropertyName("chargedCycles")]
        public int? ChargedCycles { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("currentCycle")]
        public int? CurrentCycle { get; set; }

        [JsonPropertyName("currentPeriodEnd")]
        public DateTime? CurrentPeriodEnd { get; set; }

        [JsonPropertyName("currentPeriodStart")]
        public DateTime? CurrentPeriodStart { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("end")]
        public DateTime? End { get; set; }

        [JsonPropertyName("entitlements")]
        public List<EntitlementSummary>? Entitlements { get; set; }

        [JsonPropertyName("firstSubscribe")]
        public bool? FirstSubscribe { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("inFixedCycleTrial")]
        public bool? InFixedCycleTrial { get; set; }

        [JsonPropertyName("inFixedFreeDays")]
        public bool? InFixedFreeDays { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSnapshot")]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("nextBillingDate")]
        public DateTime? NextBillingDate { get; set; }

        [JsonPropertyName("paid")]
        public bool? Paid { get; set; }

        [JsonPropertyName("paymentFlowRequired")]
        public bool? PaymentFlowRequired { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurring")]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("retryAttempted")]
        public int? RetryAttempted { get; set; }

        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; }

        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public SubscriptionInfoStatus? Status { get; set; }

        [JsonPropertyName("subscribedAt")]
        public DateTime? SubscribedAt { get; set; }

        [JsonPropertyName("subscribedBy")]
        [JsonStringEnum]
        public SubscriptionInfoSubscribedBy? SubscribedBy { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("trialPrice")]
        public int? TrialPrice { get; set; }

        [JsonPropertyName("trialedCycles")]
        public int? TrialedCycles { get; set; }

        [JsonPropertyName("unsubscribeReason")]
        public string? UnsubscribeReason { get; set; }

        [JsonPropertyName("unsubscribedAt")]
        public DateTime? UnsubscribedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class SubscriptionInfoChargeStatus : StringEnum<SubscriptionInfoChargeStatus>
    {
        public static readonly SubscriptionInfoChargeStatus NEVER
            = new SubscriptionInfoChargeStatus("NEVER");

        public static readonly SubscriptionInfoChargeStatus SETUP
            = new SubscriptionInfoChargeStatus("SETUP");

        public static readonly SubscriptionInfoChargeStatus RECURRINGCHARGING
            = new SubscriptionInfoChargeStatus("RECURRING_CHARGING");

        public static readonly SubscriptionInfoChargeStatus CHARGED
            = new SubscriptionInfoChargeStatus("CHARGED");

        public static readonly SubscriptionInfoChargeStatus CHARGEFAILED
            = new SubscriptionInfoChargeStatus("CHARGE_FAILED");


        public static implicit operator SubscriptionInfoChargeStatus(string value)
        {
            return Create(value);
        }

        public SubscriptionInfoChargeStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class SubscriptionInfoStatus : StringEnum<SubscriptionInfoStatus>
    {
        public static readonly SubscriptionInfoStatus INIT
            = new SubscriptionInfoStatus("INIT");

        public static readonly SubscriptionInfoStatus ACTIVE
            = new SubscriptionInfoStatus("ACTIVE");

        public static readonly SubscriptionInfoStatus CANCELLED
            = new SubscriptionInfoStatus("CANCELLED");

        public static readonly SubscriptionInfoStatus EXPIRED
            = new SubscriptionInfoStatus("EXPIRED");


        public static implicit operator SubscriptionInfoStatus(string value)
        {
            return Create(value);
        }

        public SubscriptionInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class SubscriptionInfoSubscribedBy : StringEnum<SubscriptionInfoSubscribedBy>
    {
        public static readonly SubscriptionInfoSubscribedBy USER
            = new SubscriptionInfoSubscribedBy("USER");

        public static readonly SubscriptionInfoSubscribedBy PLATFORM
            = new SubscriptionInfoSubscribedBy("PLATFORM");


        public static implicit operator SubscriptionInfoSubscribedBy(string value)
        {
            return Create(value);
        }

        public SubscriptionInfoSubscribedBy(string enumValue)
            : base(enumValue)
        {

        }
    }    
}