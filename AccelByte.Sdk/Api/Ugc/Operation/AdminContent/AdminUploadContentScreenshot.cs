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
    /// AdminUploadContentScreenshot
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [CREATE].
    /// 
    /// All request body are required except for contentType field.
    /// contentType values is used to enforce the Content-Type header needed by the client to upload the content using the presigned URL.
    /// If not specified, it will use fileExtension value.
    /// Supported file extensions: pjp, jpg, jpeg, jfif, bmp, png.
    /// 
    /// Maximum description length: 1024.
    /// </summary>
    public class AdminUploadContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        public AdminUploadContentScreenshot(
            string contentId,            
            string namespace_,            
            Model.ModelsCreateScreenshotRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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