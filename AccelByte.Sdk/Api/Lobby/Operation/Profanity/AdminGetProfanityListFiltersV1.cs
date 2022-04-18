// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminGetProfanityListFiltersV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [READ]` with scope `social`
    /// 
    /// get the list of filters inside the list.
    /// </summary>
    public class AdminGetProfanityListFiltersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetProfanityListFiltersV1Builder Builder = new AdminGetProfanityListFiltersV1Builder();

        public class AdminGetProfanityListFiltersV1Builder
            : OperationBuilder<AdminGetProfanityListFiltersV1Builder>
        {
            
            
            internal AdminGetProfanityListFiltersV1Builder() { }





            public AdminGetProfanityListFiltersV1 Build(
                string list,
                string namespace_
            )
            {
                AdminGetProfanityListFiltersV1 op = new AdminGetProfanityListFiltersV1(this,
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetProfanityListFiltersV1(AdminGetProfanityListFiltersV1Builder builder,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetProfanityListFiltersV1(
            string list,            
            string namespace_            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsAdminGetProfanityListFiltersV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminGetProfanityListFiltersV1Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminGetProfanityListFiltersV1Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}