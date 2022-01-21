using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class ImportRewards : AccelByte.Sdk.Core.Operation
    {
        public ImportRewards(
            string namespace_,            
            bool replaceExisting,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            QueryParams["replaceExisting"] = Convert.ToString(replaceExisting)!;
            
            if (file != null) FormParams["file"] = file;
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}