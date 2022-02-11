using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// createPaymentProviderConfig
    ///
    /// Create payment provider config.
    /// 
    /// 
    /// 
    ///      Request Body Parameters:
    /// 
    /// 
    ///      Parameter| Type| Required| Description
    ///     ---|---|---|---
    ///     namespace| String| Yes| namespace, * indicates all namespace
    ///     region| String| Yes| region, * indicates all regions
    ///     aggregate| String| No| aggregate payment provider, such as XSOLLA, ADYEN, STRIPE
    ///     specials| List| No| special payment provider, such as ALIPAY, WXPAY
    /// 
    /// payment provider applied has priority:
    /// 
    ///   1. namespace and region match
    ///   2. namespace matches and region is *
    ///   3. region matches and namespace is *
    ///   4. namespace and region are *
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=1 (CREATE)
    ///   *  Returns : payment provider config
    /// </summary>
    public class CreatePaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        public CreatePaymentProviderConfig(
            Model.PaymentProviderConfigEdit body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/payment/config/provider";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentProviderConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}