using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    public class ResetUserSeason : AccelByte.Sdk.Core.Operation
    {
        public ResetUserSeason(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/reset";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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