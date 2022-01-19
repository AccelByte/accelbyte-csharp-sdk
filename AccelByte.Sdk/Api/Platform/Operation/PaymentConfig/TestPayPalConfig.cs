using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class TestPayPalConfig : AccelByte.Sdk.Core.Operation
    {
        public TestPayPalConfig(
            bool? sandbox,            
            Model.PayPalConfig body            
        )
        {
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/payment/config/merchant/paypalconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.TestResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}