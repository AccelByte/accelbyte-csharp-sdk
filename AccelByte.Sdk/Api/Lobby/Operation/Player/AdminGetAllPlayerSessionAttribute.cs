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
    /// adminGetAllPlayerSessionAttribute
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:USER:{userId}:PLAYER:ATTRIBUTES [READ]` with scope `social`
    /// 
    /// get all player's session attribute by user id in a namespace.
    /// </summary>
    public class AdminGetAllPlayerSessionAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetAllPlayerSessionAttributeBuilder Builder = new AdminGetAllPlayerSessionAttributeBuilder();

        public class AdminGetAllPlayerSessionAttributeBuilder
            : OperationBuilder<AdminGetAllPlayerSessionAttributeBuilder>
        {
            
            
            internal AdminGetAllPlayerSessionAttributeBuilder() { }






            public AdminGetAllPlayerSessionAttribute Build(
                string namespace_,
                string userId
            )
            {
                AdminGetAllPlayerSessionAttribute op = new AdminGetAllPlayerSessionAttribute(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetAllPlayerSessionAttribute(AdminGetAllPlayerSessionAttributeBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetAllPlayerSessionAttribute(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetAllPlayerSessionAttributeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerSessionAttributeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllPlayerSessionAttributeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}