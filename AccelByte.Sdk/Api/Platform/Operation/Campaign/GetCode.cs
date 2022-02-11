using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getCode
    ///
    /// Get campaign code, it will check code whether available to redeem if
    /// redeemable true.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=2 (READ) (READ)
    ///   *  Returns : code info
    /// </summary>
    public class GetCode : AccelByte.Sdk.Core.Operation
    {
        public GetCode(
            string code,            
            string namespace_,            
            bool? redeemable            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            
            if (redeemable != null) QueryParams["redeemable"] = Convert.ToString(redeemable)!;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/{code}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CodeInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}