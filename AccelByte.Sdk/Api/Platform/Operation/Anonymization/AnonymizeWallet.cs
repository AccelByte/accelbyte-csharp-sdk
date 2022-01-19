using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class AnonymizeWallet : AccelByte.Sdk.Core.Operation
    {
        public AnonymizeWallet(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/wallets";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}