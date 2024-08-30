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
    /// publicTransferUserEntitlement
    ///
    /// Transfer a specified use count from entitlement A to B..Other detail info:
    ///   * Returns : entitlement
    /// </summary>
    public class PublicTransferUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicTransferUserEntitlementBuilder Builder { get => new PublicTransferUserEntitlementBuilder(); }

        public class PublicTransferUserEntitlementBuilder
            : OperationBuilder<PublicTransferUserEntitlementBuilder>
        {





            internal PublicTransferUserEntitlementBuilder() { }






            public PublicTransferUserEntitlement Build(
                EntitlementTransferRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicTransferUserEntitlement op = new PublicTransferUserEntitlement(this,
                    body,
                    entitlementId,
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

        private PublicTransferUserEntitlement(PublicTransferUserEntitlementBuilder builder,
            EntitlementTransferRequest body,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicTransferUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementTransferRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/transfer";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementTransferResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.EntitlementTransferResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.EntitlementTransferResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementTransferResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}