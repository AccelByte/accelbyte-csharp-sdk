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
    /// adminVerifyMessageProfanityResponse
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [READ]` with scope `social`
    /// 
    /// verify a message directly from the UI or other services
    /// </summary>
    public class AdminVerifyMessageProfanityResponse : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminVerifyMessageProfanityResponseBuilder Builder = new AdminVerifyMessageProfanityResponseBuilder();

        public class AdminVerifyMessageProfanityResponseBuilder
            : OperationBuilder<AdminVerifyMessageProfanityResponseBuilder>
        {
            
            
            internal AdminVerifyMessageProfanityResponseBuilder() { }






            public AdminVerifyMessageProfanityResponse Build(
                ModelsAdminVerifyMessageProfanityRequest body,
                string namespace_
            )
            {
                AdminVerifyMessageProfanityResponse op = new AdminVerifyMessageProfanityResponse(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminVerifyMessageProfanityResponse(AdminVerifyMessageProfanityResponseBuilder builder,
            ModelsAdminVerifyMessageProfanityRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminVerifyMessageProfanityResponse(
            string namespace_,            
            Model.ModelsAdminVerifyMessageProfanityRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsAdminVerifyMessageProfanityResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminVerifyMessageProfanityResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminVerifyMessageProfanityResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}