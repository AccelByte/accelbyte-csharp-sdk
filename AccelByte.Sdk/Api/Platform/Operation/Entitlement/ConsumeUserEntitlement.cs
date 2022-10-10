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
    /// consumeUserEntitlement
    ///
    /// Consume user entitlement. If the entitlement useCount is 0, the status will be CONSUMED.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : consumed entitlement
    /// </summary>
    public class ConsumeUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ConsumeUserEntitlementBuilder Builder = new ConsumeUserEntitlementBuilder();

        public class ConsumeUserEntitlementBuilder
            : OperationBuilder<ConsumeUserEntitlementBuilder>
        {


            public Model.EntitlementDecrement? Body { get; set; }




            internal ConsumeUserEntitlementBuilder() { }



            public ConsumeUserEntitlementBuilder SetBody(Model.EntitlementDecrement _body)
            {
                Body = _body;
                return this;
            }




            public ConsumeUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                ConsumeUserEntitlement op = new ConsumeUserEntitlement(this,
                    entitlementId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ConsumeUserEntitlement(ConsumeUserEntitlementBuilder builder,
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

        public ConsumeUserEntitlement(
            string entitlementId,
            string namespace_,
            string userId,
            Model.EntitlementDecrement body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.TrackedEntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TrackedEntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TrackedEntitlementInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}