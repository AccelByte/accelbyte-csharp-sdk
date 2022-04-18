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
    /// adminAddProfanityFilterIntoList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [CREATE]` with scope `social`
    /// 
    /// add a single filter into the list
    /// </summary>
    public class AdminAddProfanityFilterIntoList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddProfanityFilterIntoListBuilder Builder = new AdminAddProfanityFilterIntoListBuilder();

        public class AdminAddProfanityFilterIntoListBuilder
            : OperationBuilder<AdminAddProfanityFilterIntoListBuilder>
        {
            
            
            
            internal AdminAddProfanityFilterIntoListBuilder() { }





            public AdminAddProfanityFilterIntoList Build(
                ModelsAdminAddProfanityFilterIntoListRequest body,
                string list,
                string namespace_
            )
            {
                AdminAddProfanityFilterIntoList op = new AdminAddProfanityFilterIntoList(this,
                    body,                    
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminAddProfanityFilterIntoList(AdminAddProfanityFilterIntoListBuilder builder,
            ModelsAdminAddProfanityFilterIntoListRequest body,
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

        public AdminAddProfanityFilterIntoList(
            string list,            
            string namespace_,            
            Model.ModelsAdminAddProfanityFilterIntoListRequest body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters";

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