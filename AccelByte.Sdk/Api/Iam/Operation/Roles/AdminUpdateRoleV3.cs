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
    /// AdminUpdateRoleV3
    ///
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// Update role request body:
    /// - roleName: specify role name, alphanumeric, cannot have special character (required)
    /// - isWildcard: specify if role can be assigned to wildcard (*) namespace (default false)
    /// - deletable: specify if role can be deleted or not (optional)
    /// 
    /// 
    /// action code: 10402
    /// </summary>
    public class AdminUpdateRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateRoleV3Builder Builder { get => new AdminUpdateRoleV3Builder(); }

        public class AdminUpdateRoleV3Builder
            : OperationBuilder<AdminUpdateRoleV3Builder>
        {





            internal AdminUpdateRoleV3Builder() { }






            public AdminUpdateRoleV3 Build(
                ModelRoleUpdateRequestV3 body,
                string roleId
            )
            {
                AdminUpdateRoleV3 op = new AdminUpdateRoleV3(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateRoleV3(AdminUpdateRoleV3Builder builder,
            ModelRoleUpdateRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateRoleV3(
            string roleId,
            Model.ModelRoleUpdateRequestV3 body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelRoleResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseV3>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}