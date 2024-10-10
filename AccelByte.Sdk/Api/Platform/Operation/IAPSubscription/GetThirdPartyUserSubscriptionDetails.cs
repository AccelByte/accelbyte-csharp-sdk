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
    /// getThirdPartyUserSubscriptionDetails
    ///
    /// Admin get user subscription details.Other detail info:
    ///   * Returns :
    /// </summary>
    public class GetThirdPartyUserSubscriptionDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetThirdPartyUserSubscriptionDetailsBuilder Builder { get => new GetThirdPartyUserSubscriptionDetailsBuilder(); }

        public class GetThirdPartyUserSubscriptionDetailsBuilder
            : OperationBuilder<GetThirdPartyUserSubscriptionDetailsBuilder>
        {





            internal GetThirdPartyUserSubscriptionDetailsBuilder() { }






            public GetThirdPartyUserSubscriptionDetails Build(
                string id,
                string namespace_,
                string userId
            )
            {
                GetThirdPartyUserSubscriptionDetails op = new GetThirdPartyUserSubscriptionDetails(this,
                    id,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetThirdPartyUserSubscriptionDetails(GetThirdPartyUserSubscriptionDetailsBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetThirdPartyUserSubscriptionDetails(
            string id,
            string namespace_,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/{id}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ThirdPartyUserSubscriptionInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ThirdPartyUserSubscriptionInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ThirdPartyUserSubscriptionInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ThirdPartyUserSubscriptionInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}