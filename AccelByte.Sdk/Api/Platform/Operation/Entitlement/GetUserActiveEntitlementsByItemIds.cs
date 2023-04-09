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
    /// getUserActiveEntitlementsByItemIds
    ///
    /// Get user entitlements by itemIds.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserActiveEntitlementsByItemIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserActiveEntitlementsByItemIdsBuilder Builder { get => new GetUserActiveEntitlementsByItemIdsBuilder(); }

        public class GetUserActiveEntitlementsByItemIdsBuilder
            : OperationBuilder<GetUserActiveEntitlementsByItemIdsBuilder>
        {

            public List<string>? Ids { get; set; }





            internal GetUserActiveEntitlementsByItemIdsBuilder() { }


            public GetUserActiveEntitlementsByItemIdsBuilder SetIds(List<string> _ids)
            {
                Ids = _ids;
                return this;
            }





            public GetUserActiveEntitlementsByItemIds Build(
                string namespace_,
                string userId
            )
            {
                GetUserActiveEntitlementsByItemIds op = new GetUserActiveEntitlementsByItemIds(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserActiveEntitlementsByItemIds(GetUserActiveEntitlementsByItemIdsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Ids is not null) QueryParams["ids"] = builder.Ids;



            CollectionFormatMap["ids"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserActiveEntitlementsByItemIds(
            string namespace_,
            string userId,
            List<string>? ids
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (ids is not null) QueryParams["ids"] = ids;



            CollectionFormatMap["ids"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.EntitlementInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.EntitlementInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.EntitlementInfo>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}