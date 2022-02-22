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
    /// generatedUploadUrl
    ///
    /// Generate an upload URL. It's valid for 10 minutes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:FILEUPLOAD" , action=1 (CREATE)
    ///   *  Action code : 11101
    ///   *  Returns : URL data
    /// </summary>
    public class GeneratedUploadUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GeneratedUploadUrlBuilder Builder = new GeneratedUploadUrlBuilder();

        public class GeneratedUploadUrlBuilder
        {
            
            
            
            internal GeneratedUploadUrlBuilder() { }





            public GeneratedUploadUrl Build(
                string folder,
                string namespace_,
                string fileType
            )
            {
                return new GeneratedUploadUrl(this,
                    folder,                    
                    namespace_,                    
                    fileType                    
                );
            }
        }

        private GeneratedUploadUrl(GeneratedUploadUrlBuilder builder,
            string folder,
            string namespace_,
            string fileType
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;
            
            if (fileType != null) QueryParams["fileType"] = fileType;
            
            
            
            
        }
        #endregion

        public GeneratedUploadUrl(
            string folder,            
            string namespace_,            
            string fileType            
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;
            
            if (fileType != null) QueryParams["fileType"] = fileType;
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/folders/{folder}/files";

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