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
    /// AdminUpdateClientPermissionV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// action code: 10307
    /// </summary>
    public class AdminUpdateClientPermissionV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateClientPermissionV3Builder Builder { get => new AdminUpdateClientPermissionV3Builder(); }

        public class AdminUpdateClientPermissionV3Builder
            : OperationBuilder<AdminUpdateClientPermissionV3Builder>
        {





            internal AdminUpdateClientPermissionV3Builder() { }






            public AdminUpdateClientPermissionV3 Build(
                AccountcommonClientPermissionsV3 body,
                string clientId,
                string namespace_
            )
            {
                AdminUpdateClientPermissionV3 op = new AdminUpdateClientPermissionV3(this,
                    body,
                    clientId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateClientPermissionV3(AdminUpdateClientPermissionV3Builder builder,
            AccountcommonClientPermissionsV3 body,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateClientPermissionV3(
            string clientId,
            string namespace_,
            Model.AccountcommonClientPermissionsV3 body
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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