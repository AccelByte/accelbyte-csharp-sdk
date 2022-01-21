using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class PublicGetQRCode : AccelByte.Sdk.Core.Operation
    {
        public PublicGetQRCode(
            string namespace_,            
            string code            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (code != null) QueryParams["code"] = code;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/qrcode";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "image/png" };

        public override string? Security {get; set;} = "Bearer";
        
        public byte[]? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<byte[]>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}