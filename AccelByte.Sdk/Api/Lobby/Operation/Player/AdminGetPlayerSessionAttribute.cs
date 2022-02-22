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
    /// adminGetPlayerSessionAttribute
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PLAYER:ATTRIBUTES [READ]` with scope `social`
    /// 
    /// get player's specific session attribute by user id in a namespace.
    /// </summary>
    public class AdminGetPlayerSessionAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerSessionAttributeBuilder Builder = new AdminGetPlayerSessionAttributeBuilder();

        public class AdminGetPlayerSessionAttributeBuilder
        {
            
            
            
            internal AdminGetPlayerSessionAttributeBuilder() { }





            public AdminGetPlayerSessionAttribute Build(
                string attribute,
                string namespace_,
                string userId
            )
            {
                return new AdminGetPlayerSessionAttribute(this,
                    attribute,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminGetPlayerSessionAttribute(AdminGetPlayerSessionAttributeBuilder builder,
            string attribute,
            string namespace_,
            string userId
        )
        {
            PathParams["attribute"] = attribute;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminGetPlayerSessionAttribute(
            string attribute,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["attribute"] = attribute;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes/{attribute}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetPlayerSessionAttributeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetPlayerSessionAttributeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetPlayerSessionAttributeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}