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
    /// AdminGetUserByUserIdV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [READ]'
    /// </summary>
    public class AdminGetUserByUserIdV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserByUserIdV3Builder Builder = new AdminGetUserByUserIdV3Builder();

        public class AdminGetUserByUserIdV3Builder
        {
            
            
            internal AdminGetUserByUserIdV3Builder() { }





            public AdminGetUserByUserIdV3 Build(
                string namespace_,
                string userId
            )
            {
                return new AdminGetUserByUserIdV3(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetUserByUserIdV3(AdminGetUserByUserIdV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminGetUserByUserIdV3(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}