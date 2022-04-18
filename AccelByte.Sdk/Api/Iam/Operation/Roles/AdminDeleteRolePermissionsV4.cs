// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminDeleteRolePermissionsV4
    ///
    /// Required permission ADMIN:ROLE [UPDATE]
    /// </summary>
    public class AdminDeleteRolePermissionsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRolePermissionsV4Builder Builder = new AdminDeleteRolePermissionsV4Builder();

        public class AdminDeleteRolePermissionsV4Builder
            : OperationBuilder<AdminDeleteRolePermissionsV4Builder>
        {
            
            
            internal AdminDeleteRolePermissionsV4Builder() { }





            public AdminDeleteRolePermissionsV4 Build(
                List<string> body,
                string roleId
            )
            {
                AdminDeleteRolePermissionsV4 op = new AdminDeleteRolePermissionsV4(this,
                    body,                    
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteRolePermissionsV4(AdminDeleteRolePermissionsV4Builder builder,
            List<string> body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteRolePermissionsV4(
            string roleId,            
            List<string> body            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/permissions";

        public override HttpMethod Method => HttpMethod.Delete;

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