using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
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
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}