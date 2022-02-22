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
    /// SingleAdminUpdateContentDirect
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// 
    /// All request body are required except preview and tags.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SingleAdminUpdateContentDirect : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminUpdateContentDirectBuilder Builder = new SingleAdminUpdateContentDirectBuilder();

        public class SingleAdminUpdateContentDirectBuilder
        {
            
            
            
            
            internal SingleAdminUpdateContentDirectBuilder() { }





            public SingleAdminUpdateContentDirect Build(
                ModelsCreateContentRequest body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                return new SingleAdminUpdateContentDirect(this,
                    body,                    
                    channelId,                    
                    contentId,                    
                    namespace_                    
                );
            }
        }

        private SingleAdminUpdateContentDirect(SingleAdminUpdateContentDirectBuilder builder,
            ModelsCreateContentRequest body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public SingleAdminUpdateContentDirect(
            string channelId,            
            string contentId,            
            string namespace_,            
            Model.ModelsCreateContentRequest body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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