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
    /// revokeUserEntitlements
    ///
    /// Revoke user's entitlements by ids.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : revoke entitlements count
    /// </summary>
    public class RevokeUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeUserEntitlementsBuilder Builder { get => new RevokeUserEntitlementsBuilder(); }

        public class RevokeUserEntitlementsBuilder
            : OperationBuilder<RevokeUserEntitlementsBuilder>
        {





            internal RevokeUserEntitlementsBuilder() { }






            public RevokeUserEntitlements Build(
                string namespace_,
                string userId,
                string entitlementIds
            )
            {
                RevokeUserEntitlements op = new RevokeUserEntitlements(this,
                    namespace_,
                    userId,
                    entitlementIds
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RevokeUserEntitlements(RevokeUserEntitlementsBuilder builder,
            string namespace_,
            string userId,
            string entitlementIds
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (entitlementIds is not null) QueryParams["entitlementIds"] = entitlementIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RevokeUserEntitlements(
            string namespace_,
            string userId,
            string entitlementIds
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (entitlementIds is not null) QueryParams["entitlementIds"] = entitlementIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke/byIds";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}