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
    /// deleteUserSubscription
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Delete user subscription.
    /// </summary>
    public class DeleteUserSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserSubscriptionBuilder Builder { get => new DeleteUserSubscriptionBuilder(); }

        public class DeleteUserSubscriptionBuilder
            : OperationBuilder<DeleteUserSubscriptionBuilder>
        {





            internal DeleteUserSubscriptionBuilder() { }






            public DeleteUserSubscription Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                DeleteUserSubscription op = new DeleteUserSubscription(this,
                    namespace_,
                    subscriptionId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteUserSubscription(DeleteUserSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserSubscription(
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}