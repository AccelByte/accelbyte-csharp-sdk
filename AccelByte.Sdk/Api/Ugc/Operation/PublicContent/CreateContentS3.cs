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
    /// CreateContentS3
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [CREATE].
    /// 
    /// All request body are required except payload, preview, tags, and contentType.
    /// contentType values is used to enforce the Content-Type header needed by the client to upload the content using the S3 presigned URL.
    /// If not specified, it will use fileExtension value.
    /// </summary>
    public class CreateContentS3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateContentS3Builder Builder = new CreateContentS3Builder();

        public class CreateContentS3Builder
        {
            
            
            
            
            internal CreateContentS3Builder() { }





            public CreateContentS3 Build(
                ModelsCreateContentRequestS3 body,
                string channelId,
                string namespace_,
                string userId
            )
            {
                return new CreateContentS3(this,
                    body,                    
                    channelId,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private CreateContentS3(CreateContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public CreateContentS3(
            string channelId,            
            string namespace_,            
            string userId,            
            Model.ModelsCreateContentRequestS3 body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

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