using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGeneratedUploadUrl
    ///
    /// Generate an upload URL. It's valid for 10 minutes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "NAMESPACE:{namespace}:FILEUPLOAD" , action=1 (CREATE)
    ///   *  Action code : 11101
    ///   *  Returns : URL data
    /// </summary>
    public class PublicGeneratedUploadUrl : AccelByte.Sdk.Core.Operation
    {
        public PublicGeneratedUploadUrl(
            string folder,            
            string namespace_,            
            string fileType            
        )
        {
            PathParams["folder"] = folder;
            PathParams["namespace"] = namespace_;
            
            if (fileType != null) QueryParams["fileType"] = fileType;
            
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/folders/{folder}/files";

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