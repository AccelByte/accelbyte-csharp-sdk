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
    /// revokeUserEntitlementByUseCount
    ///
    /// Revoke specified count of user entitlement.
    /// Other detail info:
    /// 
    ///   * Returns : The revoked entitlement
    /// </summary>
    public class RevokeUserEntitlementByUseCount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeUserEntitlementByUseCountBuilder Builder { get => new RevokeUserEntitlementByUseCountBuilder(); }

        public class RevokeUserEntitlementByUseCountBuilder
            : OperationBuilder<RevokeUserEntitlementByUseCountBuilder>
        {





            internal RevokeUserEntitlementByUseCountBuilder() { }






            public RevokeUserEntitlementByUseCount Build(
                RevokeUseCountRequest body,
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                RevokeUserEntitlementByUseCount op = new RevokeUserEntitlementByUseCount(this,
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

        private RevokeUserEntitlementByUseCount(RevokeUserEntitlementByUseCountBuilder builder,
            RevokeUseCountRequest body,
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

        public RevokeUserEntitlementByUseCount(
            string entitlementId,
            string namespace_,
            string userId,
            Model.RevokeUseCountRequest body
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke/byUseCount";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementIfc? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.EntitlementIfc>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.EntitlementIfc>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementIfc>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}