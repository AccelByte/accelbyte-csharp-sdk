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
    /// AdminGetUserByUserIdV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [READ]'
    /// </summary>
    public class AdminGetUserByUserIdV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserByUserIdV2Builder Builder = new AdminGetUserByUserIdV2Builder();

        public class AdminGetUserByUserIdV2Builder
        {
            
            
            internal AdminGetUserByUserIdV2Builder() { }





            public AdminGetUserByUserIdV2 Build(
                string namespace_,
                string userId
            )
            {
                return new AdminGetUserByUserIdV2(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetUserByUserIdV2(AdminGetUserByUserIdV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminGetUserByUserIdV2(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}