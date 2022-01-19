using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class GetUserByPlatformUserID : AccelByte.Sdk.Core.Operation
    {
        public GetUserByPlatformUserID(
            string namespace_,            
            string platformID,            
            string platformUserID            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (platformID != null) QueryParams["platformID"] = platformID;
            if (platformUserID != null) QueryParams["platformUserID"] = platformUserID;
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/byPlatformUserID";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelPublicUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}