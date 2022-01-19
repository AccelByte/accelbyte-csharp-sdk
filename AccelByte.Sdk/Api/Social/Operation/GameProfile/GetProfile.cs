using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class GetProfile : AccelByte.Sdk.Core.Operation
    {
        public GetProfile(
            string namespace_,            
            string profileId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/profiles/{profileId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.GameProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}