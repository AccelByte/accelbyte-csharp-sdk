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
    /// AdminPutUserRolesV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [UPDATE]'
    /// </summary>
    public class AdminPutUserRolesV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutUserRolesV2Builder Builder = new AdminPutUserRolesV2Builder();

        public class AdminPutUserRolesV2Builder
        {
            
            
            
            internal AdminPutUserRolesV2Builder() { }





            public AdminPutUserRolesV2 Build(
                List<string> body,
                string namespace_,
                string userId
            )
            {
                return new AdminPutUserRolesV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminPutUserRolesV2(AdminPutUserRolesV2Builder builder,
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

        public AdminPutUserRolesV2(
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

        public override HttpMethod Method => HttpMethod.Put;

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