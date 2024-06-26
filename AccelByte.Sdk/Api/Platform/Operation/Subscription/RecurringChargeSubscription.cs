// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// recurringChargeSubscription
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Recurring charge subscription, it will trigger recurring charge if the USER subscription status is ACTIVE, nextBillingDate is before now and no fail recurring charge within X(default 12) hours.
    /// Other detail info:
    /// 
    ///   * Returns : recurring charge result
    /// </summary>
    public class RecurringChargeSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RecurringChargeSubscriptionBuilder Builder { get => new RecurringChargeSubscriptionBuilder(); }

        public class RecurringChargeSubscriptionBuilder
            : OperationBuilder<RecurringChargeSubscriptionBuilder>
        {





            internal RecurringChargeSubscriptionBuilder() { }






            public RecurringChargeSubscription Build(
                string namespace_,
                string subscriptionId
            )
            {
                RecurringChargeSubscription op = new RecurringChargeSubscription(this,
                    namespace_,
                    subscriptionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RecurringChargeSubscription(RecurringChargeSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RecurringChargeSubscription(
            string namespace_,
            string subscriptionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/subscriptions/{subscriptionId}/recurring";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RecurringChargeResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RecurringChargeResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RecurringChargeResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RecurringChargeResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}