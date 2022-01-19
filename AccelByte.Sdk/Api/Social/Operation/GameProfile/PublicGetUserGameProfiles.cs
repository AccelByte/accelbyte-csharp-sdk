using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class PublicGetUserGameProfiles : AccelByte.Sdk.Core.Operation
    {
        public PublicGetUserGameProfiles(
            string namespace_,            
            List<string> userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            QueryParams["userIds"] = Convert.ToString(userIds)!;
            
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.UserGameProfiles>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserGameProfiles>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}