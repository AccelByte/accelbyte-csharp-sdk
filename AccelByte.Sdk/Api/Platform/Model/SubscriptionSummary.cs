// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SubscriptionSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currentPeriodEnd")]
        public DateTime? CurrentPeriodEnd { get; set; }

        [JsonPropertyName("currentPeriodStart")]
        public DateTime? CurrentPeriodStart { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public SubscriptionSummaryStatus? Status { get; set; }

        [JsonPropertyName("subscribedBy")]
        [JsonStringEnum]
        public SubscriptionSummarySubscribedBy? SubscribedBy { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class SubscriptionSummaryStatus : StringEnum<SubscriptionSummaryStatus>
    {
        public static readonly SubscriptionSummaryStatus INIT
            = new SubscriptionSummaryStatus("INIT");

        public static readonly SubscriptionSummaryStatus ACTIVE
            = new SubscriptionSummaryStatus("ACTIVE");

        public static readonly SubscriptionSummaryStatus CANCELLED
            = new SubscriptionSummaryStatus("CANCELLED");

        public static readonly SubscriptionSummaryStatus EXPIRED
            = new SubscriptionSummaryStatus("EXPIRED");


        public static implicit operator SubscriptionSummaryStatus(string value)
        {
            return Create(value);
        }

        public SubscriptionSummaryStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class SubscriptionSummarySubscribedBy : StringEnum<SubscriptionSummarySubscribedBy>
    {
        public static readonly SubscriptionSummarySubscribedBy USER
            = new SubscriptionSummarySubscribedBy("USER");

        public static readonly SubscriptionSummarySubscribedBy PLATFORM
            = new SubscriptionSummarySubscribedBy("PLATFORM");


        public static implicit operator SubscriptionSummarySubscribedBy(string value)
        {
            return Create(value);
        }

        public SubscriptionSummarySubscribedBy(string enumValue)
            : base(enumValue)
        {

        }
    }    
}