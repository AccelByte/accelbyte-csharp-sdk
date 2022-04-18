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
    /// UploadContentScreenshot
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [CREATE].
    /// 
    /// All request body are required except for contentType field.
    /// contentType values is used to enforce the Content-Type header needed by the client to upload the content using the presigned URL.
    /// If not specified, it will use fileExtension value.
    /// Supported file extensions: pjp, jpg, jpeg, jfif, bmp, png.
    /// 
    /// Maximum description length: 1024.
    /// </summary>
    public class UploadContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UploadContentScreenshotBuilder Builder = new UploadContentScreenshotBuilder();

        public class UploadContentScreenshotBuilder
            : OperationBuilder<UploadContentScreenshotBuilder>
        {
            
            
            
            
            internal UploadContentScreenshotBuilder() { }





            public UploadContentScreenshot Build(
                ModelsCreateScreenshotRequest body,
                string contentId,
                string namespace_,
                string userId
            )
            {
                UploadContentScreenshot op = new UploadContentScreenshot(this,
                    body,                    
                    contentId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UploadContentScreenshot(UploadContentScreenshotBuilder builder,
            ModelsCreateScreenshotRequest body,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UploadContentScreenshot(
            string contentId,            
            string namespace_,            
            string userId,            
            Model.ModelsCreateScreenshotRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsCreateScreenshotResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateScreenshotResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateScreenshotResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}