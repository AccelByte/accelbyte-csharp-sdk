using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    public class ImportConfigV1 : AccelByte.Sdk.Core.Operation
    {
        public ImportConfigV1(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = Convert.ToString(file)!; // XXX Handle stream
            
            
        }

        public override string Path => "/dsmcontroller/admin/v1/namespaces/{namespace}/configs/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsImportResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}