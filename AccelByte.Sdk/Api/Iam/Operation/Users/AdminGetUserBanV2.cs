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
    /// AdminGetUserBanV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [READ]'.
    /// </summary>
    public class AdminGetUserBanV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserBanV2Builder Builder = new AdminGetUserBanV2Builder();

        public class AdminGetUserBanV2Builder
            : OperationBuilder<AdminGetUserBanV2Builder>
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            internal AdminGetUserBanV2Builder() { }


            public AdminGetUserBanV2Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }




            public AdminGetUserBanV2 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserBanV2 op = new AdminGetUserBanV2(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetUserBanV2(AdminGetUserBanV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserBanV2(
            string namespace_,            
            string userId,            
            bool? activeOnly            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelUserBanResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserBanResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserBanResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}