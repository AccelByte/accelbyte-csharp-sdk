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
    /// SingleAdminUpdateContentS3
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [UPDATE].
    /// 
    /// All request body are required except payload, preview, tags, and contentType.
    /// contentType values is used to enforce the Content-Type header needed by the client to upload the content using the S3 presigned URL.
    /// If not specified, it will use fileExtension value.
    /// </summary>
    public class SingleAdminUpdateContentS3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminUpdateContentS3Builder Builder = new SingleAdminUpdateContentS3Builder();

        public class SingleAdminUpdateContentS3Builder
            : OperationBuilder<SingleAdminUpdateContentS3Builder>
        {
            
            
            
            
            internal SingleAdminUpdateContentS3Builder() { }





            public SingleAdminUpdateContentS3 Build(
                ModelsCreateContentRequestS3 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                SingleAdminUpdateContentS3 op = new SingleAdminUpdateContentS3(this,
                    body,                    
                    channelId,                    
                    contentId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SingleAdminUpdateContentS3(SingleAdminUpdateContentS3Builder builder,
            ModelsCreateContentRequestS3 body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SingleAdminUpdateContentS3(
            string channelId,            
            string contentId,            
            string namespace_,            
            Model.ModelsCreateContentRequestS3 body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

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