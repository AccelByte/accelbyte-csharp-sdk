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
    /// AdminAddUserRoleV3
    ///
    /// 
    /// 
    /// This endpoint adds role to user. Required permission ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// action code: 10109
    /// </summary>
    public class AdminAddUserRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddUserRoleV3Builder Builder = new AdminAddUserRoleV3Builder();

        public class AdminAddUserRoleV3Builder
            : OperationBuilder<AdminAddUserRoleV3Builder>
        {
            
            
            
            internal AdminAddUserRoleV3Builder() { }






            public AdminAddUserRoleV3 Build(
                string namespace_,
                string roleId,
                string userId
            )
            {
                AdminAddUserRoleV3 op = new AdminAddUserRoleV3(this,
                    namespace_,                    
                    roleId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminAddUserRoleV3(AdminAddUserRoleV3Builder builder,
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

        public AdminAddUserRoleV3(
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

        public override HttpMethod Method => HttpMethod.Post;

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