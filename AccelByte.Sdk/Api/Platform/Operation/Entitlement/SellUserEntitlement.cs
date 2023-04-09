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
    /// sellUserEntitlement
    ///
    /// Sell user entitlement. If the entitlement is consumable, useCount is 0, the status will be CONSUMED. If the entitlement is durable, the status will be SOLD. Other detail info:
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT, action=4 (UPDATE)
    ///   *  Returns : entitlement
    /// </summary>
    public class SellUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SellUserEntitlementBuilder Builder { get => new SellUserEntitlementBuilder(); }

        public class SellUserEntitlementBuilder
            : OperationBuilder<SellUserEntitlementBuilder>
        {


            public Model.EntitlementSoldRequest? Body { get; set; }




            internal SellUserEntitlementBuilder() { }



            public SellUserEntitlementBuilder SetBody(Model.EntitlementSoldRequest _body)
            {
                Body = _body;
                return this;
            }




            public SellUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                SellUserEntitlement op = new SellUserEntitlement(this,
                    entitlementId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SellUserEntitlement(SellUserEntitlementBuilder builder,
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

        public SellUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementSoldRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/sell";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementSoldResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementSoldResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementSoldResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}