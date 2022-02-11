using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updatePaymentTaxConfig
    ///
    /// Update payment tax config.
    /// 
    /// 
    /// 
    ///      Request Body Parameters:
    /// 
    /// 
    ///      Parameter| Type| Required| Description
    ///     ---|---|---|---
    ///     taxJarEnabled| Boolean| false
    ///     taxJarApiToken| String| false| required, when taxJarEnabled is true and there is no existing token
    ///     sandboxTaxJarApiToken| String| false| optional
    ///     taxJarProductCodesMapping| Map| No| key is item type(APP|COINS|INGAMEITEM|BUNDLE|CODE|SUBSCRIPTION) and value is product tax code: https://developers.taxjar.com/api/reference/?ruby#get-list-tax-categories
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : payment global tax config
    /// </summary>
    public class UpdatePaymentTaxConfig : AccelByte.Sdk.Core.Operation
    {
        public UpdatePaymentTaxConfig(
            Model.PaymentTaxConfigEdit body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/payment/config/tax";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentTaxConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}