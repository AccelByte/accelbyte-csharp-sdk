using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class ImportStats : AccelByte.Sdk.Core.Operation
    {
        public ImportStats(
            string namespace_,            
            bool? replaceExisting,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (replaceExisting != null) QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (file != null) FormParams["file"] = file;
            
            
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StatImportInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatImportInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}