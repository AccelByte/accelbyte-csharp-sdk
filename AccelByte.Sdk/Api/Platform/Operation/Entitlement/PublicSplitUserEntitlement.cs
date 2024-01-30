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
    /// publicSplitUserEntitlement
    ///
    /// Split a specified use count of entitlement and create a new entitlement with splitting use count.Other detail info:
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : entitlement
    /// </summary>
    public class PublicSplitUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSplitUserEntitlementBuilder Builder { get => new PublicSplitUserEntitlementBuilder(); }

        public class PublicSplitUserEntitlementBuilder
            : OperationBuilder<PublicSplitUserEntitlementBuilder>
        {


            public Model.EntitlementSplitRequest? Body { get; set; }




            internal PublicSplitUserEntitlementBuilder() { }



            public PublicSplitUserEntitlementBuilder SetBody(Model.EntitlementSplitRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicSplitUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                PublicSplitUserEntitlement op = new PublicSplitUserEntitlement(this,
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

        private PublicSplitUserEntitlement(PublicSplitUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSplitUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementSplitRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/split";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementSplitResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.EntitlementSplitResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.EntitlementSplitResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementSplitResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}