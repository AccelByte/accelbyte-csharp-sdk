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
    /// AdminUpdateUserRoleV4
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:ROLE:USER:* [UPDATE] permission.
    /// 
    /// User's roles will be replaced with roles from request body.
    /// </summary>
    public class AdminUpdateUserRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserRoleV4Builder Builder = new AdminUpdateUserRoleV4Builder();

        public class AdminUpdateUserRoleV4Builder
        {
            
            
            
            internal AdminUpdateUserRoleV4Builder() { }





            public AdminUpdateUserRoleV4 Build(
                ModelAddUserRoleV4Request body,
                string namespace_,
                string userId
            )
            {
                return new AdminUpdateUserRoleV4(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminUpdateUserRoleV4(AdminUpdateUserRoleV4Builder builder,
            ModelAddUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateUserRoleV4(
            string namespace_,            
            string userId,            
            Model.ModelAddUserRoleV4Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelListUserRolesV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}