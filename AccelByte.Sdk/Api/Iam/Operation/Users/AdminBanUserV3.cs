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
    /// AdminBanUserV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [CREATE]'.
    /// 
    /// 
    /// 
    /// 
    /// Bans a user with specific type of ban. Ban types and reason can be queried.
    /// 
    /// 
    /// 
    /// 
    /// action code : 10141
    /// </summary>
    public class AdminBanUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBanUserV3Builder Builder = new AdminBanUserV3Builder();

        public class AdminBanUserV3Builder
            : OperationBuilder<AdminBanUserV3Builder>
        {
            
            
            
            internal AdminBanUserV3Builder() { }





            public AdminBanUserV3 Build(
                ModelBanCreateRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBanUserV3 op = new AdminBanUserV3(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminBanUserV3(AdminBanUserV3Builder builder,
            ModelBanCreateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBanUserV3(
            string namespace_,            
            string userId,            
            Model.ModelBanCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelUserBanResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}