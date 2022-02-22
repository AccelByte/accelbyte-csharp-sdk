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
    /// AdminRemoveUserRoleV4
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:ROLE:USER:* [Delete] permission.
    /// 
    /// Remove a role from user's roles.
    /// </summary>
    public class AdminRemoveUserRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRemoveUserRoleV4Builder Builder = new AdminRemoveUserRoleV4Builder();

        public class AdminRemoveUserRoleV4Builder
        {
            
            
            
            internal AdminRemoveUserRoleV4Builder() { }





            public AdminRemoveUserRoleV4 Build(
                ModelRemoveUserRoleV4Request body,
                string namespace_,
                string userId
            )
            {
                return new AdminRemoveUserRoleV4(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminRemoveUserRoleV4(AdminRemoveUserRoleV4Builder builder,
            ModelRemoveUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminRemoveUserRoleV4(
            string namespace_,            
            string userId,            
            Model.ModelRemoveUserRoleV4Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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