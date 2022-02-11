using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryPaymentProviderConfig
    ///
    /// Query payment provider config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider config list
    /// </summary>
    public class QueryPaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        public QueryPaymentProviderConfig(
            int? limit,            
            string? namespace_,            
            int? offset,            
            string? region            
        )
        {
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            
            
            
            
        }

        public override string Path => "/platform/admin/payment/config/provider";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentProviderConfigPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}