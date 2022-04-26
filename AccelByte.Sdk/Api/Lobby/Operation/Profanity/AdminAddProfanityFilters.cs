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
    /// adminAddProfanityFilters
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [CREATE]` with scope `social`
    /// 
    /// add multiple filters into the list
    /// </summary>
    public class AdminAddProfanityFilters : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddProfanityFiltersBuilder Builder = new AdminAddProfanityFiltersBuilder();

        public class AdminAddProfanityFiltersBuilder
            : OperationBuilder<AdminAddProfanityFiltersBuilder>
        {
            
            
            
            internal AdminAddProfanityFiltersBuilder() { }






            public AdminAddProfanityFilters Build(
                ModelsAdminAddProfanityFiltersRequest body,
                string list,
                string namespace_
            )
            {
                AdminAddProfanityFilters op = new AdminAddProfanityFilters(this,
                    body,                    
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminAddProfanityFilters(AdminAddProfanityFiltersBuilder builder,
            ModelsAdminAddProfanityFiltersRequest body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddProfanityFilters(
            string list,            
            string namespace_,            
            Model.ModelsAdminAddProfanityFiltersRequest body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}