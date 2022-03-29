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
    /// AdminBanUserV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [CREATE]'.
    /// </summary>
    public class AdminBanUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBanUserV2Builder Builder = new AdminBanUserV2Builder();

        public class AdminBanUserV2Builder
        {
            
            
            
            internal AdminBanUserV2Builder() { }





            public AdminBanUserV2 Build(
                ModelBanCreateRequest body,
                string namespace_,
                string userId
            )
            {
                return new AdminBanUserV2(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminBanUserV2(AdminBanUserV2Builder builder,
            ModelBanCreateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminBanUserV2(
            string namespace_,            
            string userId,            
            Model.ModelBanCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/ban";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserBanResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}