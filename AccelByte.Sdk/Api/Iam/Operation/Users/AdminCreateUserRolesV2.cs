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
    /// AdminCreateUserRolesV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [UPDATE]'
    /// </summary>
    public class AdminCreateUserRolesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateUserRolesV2Builder Builder = new AdminCreateUserRolesV2Builder();

        public class AdminCreateUserRolesV2Builder
        {
            
            
            
            internal AdminCreateUserRolesV2Builder() { }





            public AdminCreateUserRolesV2 Build(
                List<string> body,
                string namespace_,
                string userId
            )
            {
                return new AdminCreateUserRolesV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminCreateUserRolesV2(AdminCreateUserRolesV2Builder builder,
            List<string> body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminCreateUserRolesV2(
            string namespace_,            
            string userId,            
            List<string> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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