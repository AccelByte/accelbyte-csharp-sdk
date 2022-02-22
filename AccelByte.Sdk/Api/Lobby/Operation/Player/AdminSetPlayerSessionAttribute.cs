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
    /// adminSetPlayerSessionAttribute
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PLAYER:ATTRIBUTES [UPDATE]` with scope `social`
    /// 
    /// set player's session attribute by user id in a namespace.
    /// </summary>
    public class AdminSetPlayerSessionAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSetPlayerSessionAttributeBuilder Builder = new AdminSetPlayerSessionAttributeBuilder();

        public class AdminSetPlayerSessionAttributeBuilder
        {
            
            
            
            internal AdminSetPlayerSessionAttributeBuilder() { }





            public AdminSetPlayerSessionAttribute Build(
                ModelsSetPlayerSessionAttributeRequest body,
                string namespace_,
                string userId
            )
            {
                return new AdminSetPlayerSessionAttribute(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminSetPlayerSessionAttribute(AdminSetPlayerSessionAttributeBuilder builder,
            ModelsSetPlayerSessionAttributeRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminSetPlayerSessionAttribute(
            string namespace_,            
            string userId,            
            Model.ModelsSetPlayerSessionAttributeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

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