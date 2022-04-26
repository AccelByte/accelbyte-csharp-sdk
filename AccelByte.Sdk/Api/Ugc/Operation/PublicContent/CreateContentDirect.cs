// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// CreateContentDirect
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [CREATE].
    /// 
    /// All request body are required except preview and tags.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class CreateContentDirect : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateContentDirectBuilder Builder = new CreateContentDirectBuilder();

        public class CreateContentDirectBuilder
            : OperationBuilder<CreateContentDirectBuilder>
        {
            
            
            
            
            internal CreateContentDirectBuilder() { }






            public CreateContentDirect Build(
                ModelsCreateContentRequest body,
                string channelId,
                string namespace_,
                string userId
            )
            {
                CreateContentDirect op = new CreateContentDirect(this,
                    body,                    
                    channelId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CreateContentDirect(CreateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateContentDirect(
            string channelId,            
            string namespace_,            
            string userId,            
            Model.ModelsCreateContentRequest body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsCreateContentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateContentResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}