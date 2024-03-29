// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminDeleteClientPermissionV3
    ///
    /// **Note for Multi Tenant Mode:**
    /// This is for super admin only.
    /// action code : 10304
    /// </summary>
    public class AdminDeleteClientPermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteClientPermissionV3Builder Builder { get => new AdminDeleteClientPermissionV3Builder(); }

        public class AdminDeleteClientPermissionV3Builder
            : OperationBuilder<AdminDeleteClientPermissionV3Builder>
        {





            internal AdminDeleteClientPermissionV3Builder() { }






            public AdminDeleteClientPermissionV3 Build(
                long action,
                string clientId,
                string namespace_,
                string resource
            )
            {
                AdminDeleteClientPermissionV3 op = new AdminDeleteClientPermissionV3(this,
                    action,
                    clientId,
                    namespace_,
                    resource
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDeleteClientPermissionV3(AdminDeleteClientPermissionV3Builder builder,
            long action,
            string clientId,
            string namespace_,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteClientPermissionV3(
            long action,
            string clientId,
            string namespace_,
            string resource
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions/{resource}/{action}";

        public override HttpMethod Method => HttpMethod.Delete;

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