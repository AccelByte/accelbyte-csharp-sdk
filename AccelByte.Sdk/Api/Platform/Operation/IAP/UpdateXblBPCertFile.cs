using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class UpdateXblBPCertFile : AccelByte.Sdk.Core.Operation
    {
        public UpdateXblBPCertFile(
            string namespace_,            
            Stream? file,            
            string? password            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file != null) FormParams["file"] = Convert.ToString(file)!; // XXX Handle stream
            if (password != null) FormParams["password"] = password;
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/xbl/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.XblIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}