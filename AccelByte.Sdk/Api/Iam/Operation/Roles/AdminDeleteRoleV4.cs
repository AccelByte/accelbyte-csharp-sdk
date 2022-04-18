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
    /// AdminDeleteRoleV4
    ///
    /// Required permission ADMIN:ROLE [DELETE]
    /// 
    /// Removes role ID from user's Roles and NamespaceRoles before deleting the role.
    /// 
    /// action code: 10403
    /// </summary>
    public class AdminDeleteRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteRoleV4Builder Builder = new AdminDeleteRoleV4Builder();

        public class AdminDeleteRoleV4Builder
            : OperationBuilder<AdminDeleteRoleV4Builder>
        {
            
            internal AdminDeleteRoleV4Builder() { }





            public AdminDeleteRoleV4 Build(
                string roleId
            )
            {
                AdminDeleteRoleV4 op = new AdminDeleteRoleV4(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteRoleV4(AdminDeleteRoleV4Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteRoleV4(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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