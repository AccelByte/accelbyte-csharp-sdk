using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class Download : AccelByte.Sdk.Core.Operation
    {
        public Download(
            string campaignId,            
            string namespace_,            
            int? batchNo            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            if (batchNo != null) QueryParams["batchNo"] = Convert.ToString(batchNo)!;
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/codes.csv";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "text/csv" };

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