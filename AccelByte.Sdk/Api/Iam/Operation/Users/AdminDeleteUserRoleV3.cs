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
    /// AdminDeleteUserRoleV3
    ///
    /// 
    /// 
    /// This endpoint removes role from user. Required permission ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [DELETE]
    /// 
    /// 
    /// 
    /// 
    /// action code: 10110
    /// </summary>
    public class AdminDeleteUserRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserRoleV3Builder Builder = new AdminDeleteUserRoleV3Builder();

        public class AdminDeleteUserRoleV3Builder
            : OperationBuilder<AdminDeleteUserRoleV3Builder>
        {
            
            
            
            internal AdminDeleteUserRoleV3Builder() { }





            public AdminDeleteUserRoleV3 Build(
                string namespace_,
                string roleId,
                string userId
            )
            {
                AdminDeleteUserRoleV3 op = new AdminDeleteUserRoleV3(this,
                    namespace_,                    
                    roleId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteUserRoleV3(AdminDeleteUserRoleV3Builder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserRoleV3(
            string namespace_,            
            string roleId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/roles/{roleId}";

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