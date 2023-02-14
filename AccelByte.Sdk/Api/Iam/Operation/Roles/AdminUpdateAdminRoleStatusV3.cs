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
    /// AdminUpdateAdminRoleStatusV3
    ///
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// Admin roles has its members listed in the role.
    /// 
    /// 
    /// 
    /// 
    /// Role can be set as admin role only when it has at least 1 manager.
    /// 
    /// 
    /// 
    /// action code: 10412
    /// </summary>
    public class AdminUpdateAdminRoleStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateAdminRoleStatusV3Builder Builder { get => new AdminUpdateAdminRoleStatusV3Builder(); }

        public class AdminUpdateAdminRoleStatusV3Builder
            : OperationBuilder<AdminUpdateAdminRoleStatusV3Builder>
        {





            internal AdminUpdateAdminRoleStatusV3Builder() { }






            public AdminUpdateAdminRoleStatusV3 Build(
                string roleId
            )
            {
                AdminUpdateAdminRoleStatusV3 op = new AdminUpdateAdminRoleStatusV3(this,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateAdminRoleStatusV3(AdminUpdateAdminRoleStatusV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateAdminRoleStatusV3(
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/admin";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

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