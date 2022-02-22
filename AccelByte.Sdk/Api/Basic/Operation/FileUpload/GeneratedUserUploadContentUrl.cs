// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// generatedUserUploadContentUrl
    ///
    /// Generate an upload URL for user content. It's valid for 10 minutes.
    /// There are 2 kinds of storage limitation per user : maximum file count and maximum file size.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:USER:{userId}:FILEUPLOAD" , action=1 (CREATE)
    ///   *  Action code : 11102
    ///   *  Default maximum file count per user : 10 files
    ///   *  Default maximum file size per user : 104857600 bytes
    ///   *  Returns : URL data
    /// </summary>
    public class GeneratedUserUploadContentUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GeneratedUserUploadContentUrlBuilder Builder = new GeneratedUserUploadContentUrlBuilder();

        public class GeneratedUserUploadContentUrlBuilder
        {
            
            
            
            internal GeneratedUserUploadContentUrlBuilder() { }





            public GeneratedUserUploadContentUrl Build(
                string namespace_,
                string userId,
                string fileType
            )
            {
                return new GeneratedUserUploadContentUrl(this,
                    namespace_,                    
                    userId,                    
                    fileType                    
                );
            }
        }

        private GeneratedUserUploadContentUrl(GeneratedUserUploadContentUrlBuilder builder,
            string namespace_,
            string userId,
            string fileType
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (fileType != null) QueryParams["fileType"] = fileType;
            
            
            
            
        }
        #endregion

        public GeneratedUserUploadContentUrl(
            string namespace_,            
            string userId,            
            string fileType            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (fileType != null) QueryParams["fileType"] = fileType;
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/users/{userId}/files";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FileUploadUrlInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FileUploadUrlInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}