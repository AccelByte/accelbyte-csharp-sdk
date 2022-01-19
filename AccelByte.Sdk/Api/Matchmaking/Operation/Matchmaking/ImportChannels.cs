using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    public class ImportChannels : AccelByte.Sdk.Core.Operation
    {
        public ImportChannels(
            string namespace_,            
            Stream? file,            
            string? strategy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = Convert.ToString(file)!; // XXX Handle stream
            if (strategy != null) FormParams["strategy"] = strategy;
            
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsImportConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsImportConfigResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}