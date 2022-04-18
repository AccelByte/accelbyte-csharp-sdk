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
    /// AdminCreateRoleV3
    ///
    /// Required permission 'ADMIN:ROLE [CREATE]'
    /// 
    /// Create role request body:
    /// - roleName: specify role name, alphanumeric, cannot have special character (required)
    /// - permissions: specify the permission that this role have
    /// - managers: specify list of user that will act as the managers of this role
    /// - members: specify list of user that will act as the members of this role
    /// - adminRole: specify if role is for admin user (default false)
    /// - isWildcard: specify if role can be assigned to wildcard (*) namespace (default false)
    /// - deletable: specify if role can be deleted or not (default true)
    /// 
    /// 
    /// action code: 10401
    /// </summary>
    public class AdminCreateRoleV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateRoleV3Builder Builder = new AdminCreateRoleV3Builder();

        public class AdminCreateRoleV3Builder
            : OperationBuilder<AdminCreateRoleV3Builder>
        {
            
            internal AdminCreateRoleV3Builder() { }





            public AdminCreateRoleV3 Build(
                ModelRoleCreateV3Request body
            )
            {
                AdminCreateRoleV3 op = new AdminCreateRoleV3(this,
                    body                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminCreateRoleV3(AdminCreateRoleV3Builder builder,
            ModelRoleCreateV3Request body
        )
        {
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateRoleV3(
            Model.ModelRoleCreateV3Request body            
        )
        {
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AccountcommonRoleV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRoleV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRoleV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}