using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// DeleteImage
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE] Required
    /// scope: social This endpoint will delete an image that specified in the request
    /// parameter
    /// </summary>
    public class DeleteImage : AccelByte.Sdk.Core.Operation
    {
        public DeleteImage(
            string namespace_,            
            string imageURI,            
            string version            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (imageURI != null) QueryParams["imageURI"] = imageURI;
            if (version != null) QueryParams["version"] = version;
            
            
            
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/images";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}