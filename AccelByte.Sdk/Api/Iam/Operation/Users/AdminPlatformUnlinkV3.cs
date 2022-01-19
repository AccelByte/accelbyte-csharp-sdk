using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AdminPlatformUnlinkV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminPlatformUnlinkV3(
            string namespace_,            
            string platformId,            
            string userId,            
            Model.ModelUnlinkUserPlatformRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}";

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