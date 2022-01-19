using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    public class PublicUpdateUserProfile : AccelByte.Sdk.Core.Operation
    {
        public PublicUpdateUserProfile(
            string namespace_,            
            string userId,            
            Model.UserProfileUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfileInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}