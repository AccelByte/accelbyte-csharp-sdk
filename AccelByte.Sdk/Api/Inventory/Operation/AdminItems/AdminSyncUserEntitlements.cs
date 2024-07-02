// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminSyncUserEntitlements
    ///
    /// 
    /// Sync user's entitlement from e-commerce service to inventory for non exist item at user inventory.
    /// will skip the item if already exist at user inventory.
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [UPDATE]
    /// </summary>
    public class AdminSyncUserEntitlements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSyncUserEntitlementsBuilder Builder { get => new AdminSyncUserEntitlementsBuilder(); }

        public class AdminSyncUserEntitlementsBuilder
            : OperationBuilder<AdminSyncUserEntitlementsBuilder>
        {





            internal AdminSyncUserEntitlementsBuilder() { }






            public AdminSyncUserEntitlements Build(
                string namespace_,
                string userId
            )
            {
                AdminSyncUserEntitlements op = new AdminSyncUserEntitlements(this,
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

        private AdminSyncUserEntitlements(AdminSyncUserEntitlementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSyncUserEntitlements(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items/entitlements/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { };

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