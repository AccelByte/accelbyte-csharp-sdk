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
    /// AdminCreateRoleV4
    ///
    /// Required permission: ADMIN:ROLE [CREATE]
    /// 
    /// Create role request body:
    /// - roleName: specify role name, alphanumeric, cannot have special character (required)
    /// - adminRole: specify if role is for admin user (default false)
    /// - isWildcard: specify if role can be assigned to wildcard (*) namespace (default false)
    /// 
    /// action code: 10401
    /// </summary>
    public class AdminCreateRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateRoleV4Builder Builder = new AdminCreateRoleV4Builder();

        public class AdminCreateRoleV4Builder
        {
            
            internal AdminCreateRoleV4Builder() { }





            public AdminCreateRoleV4 Build(
                ModelRoleV4Request body
            )
            {
                return new AdminCreateRoleV4(this,
                    body                    
                );
            }
        }

        private AdminCreateRoleV4(AdminCreateRoleV4Builder builder,
            ModelRoleV4Request body
        )
        {
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminCreateRoleV4(
            Model.ModelRoleV4Request body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelRoleV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}