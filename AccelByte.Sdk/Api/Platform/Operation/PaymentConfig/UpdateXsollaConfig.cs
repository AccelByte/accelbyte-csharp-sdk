using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class UpdateXsollaConfig : AccelByte.Sdk.Core.Operation
    {
        public UpdateXsollaConfig(
            string id,            
            bool? validate,            
            Model.XsollaConfig body            
        )
        {
            PathParams["id"] = id;
            
            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/xsollaconfig";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentMerchantConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}