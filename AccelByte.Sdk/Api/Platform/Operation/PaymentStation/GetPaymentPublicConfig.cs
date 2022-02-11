using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getPaymentPublicConfig
    ///
    /// Get payment provider public config, at current only Strip provide public
    /// config.
    /// Other detail info:
    /// 
    ///   * Returns : Public config
    /// </summary>
    public class GetPaymentPublicConfig : AccelByte.Sdk.Core.Operation
    {
        public GetPaymentPublicConfig(
            string namespace_,            
            bool? sandbox,            
            string paymentProvider,            
            string region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            if (region != null) QueryParams["region"] = region;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/publicconfig";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}