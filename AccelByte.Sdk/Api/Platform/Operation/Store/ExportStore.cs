using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class ExportStore : AccelByte.Sdk.Core.Operation
    {
        public ExportStore(
            string namespace_,            
            string storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/zip" };

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