using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getPaymentCustomization
    ///
    /// Get payment provider customization, at current only Adyen provide
    /// customization.
    /// Other detail info:
    /// 
    ///   * Returns : customization
    /// </summary>
    public class GetPaymentCustomization : AccelByte.Sdk.Core.Operation
    {
        public GetPaymentCustomization(
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

        public override string Path => "/platform/public/namespaces/{namespace}/payment/customization";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.Customization? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Customization>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Customization>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}