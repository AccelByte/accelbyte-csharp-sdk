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
    /// adminUpdateProfanityList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [UPDATE]` with scope `social`
    /// 
    /// update the list
    /// </summary>
    public class AdminUpdateProfanityList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateProfanityListBuilder Builder = new AdminUpdateProfanityListBuilder();

        public class AdminUpdateProfanityListBuilder
        {
            
            
            
            internal AdminUpdateProfanityListBuilder() { }





            public AdminUpdateProfanityList Build(
                ModelsAdminUpdateProfanityList body,
                string list,
                string namespace_
            )
            {
                return new AdminUpdateProfanityList(this,
                    body,                    
                    list,                    
                    namespace_                    
                );
            }
        }

        private AdminUpdateProfanityList(AdminUpdateProfanityListBuilder builder,
            ModelsAdminUpdateProfanityList body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateProfanityList(
            string list,            
            string namespace_,            
            Model.ModelsAdminUpdateProfanityList body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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