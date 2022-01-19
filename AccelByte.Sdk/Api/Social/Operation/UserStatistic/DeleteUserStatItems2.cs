using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class DeleteUserStatItems2 : AccelByte.Sdk.Core.Operation
    {
        public DeleteUserStatItems2(
            string namespace_,            
            string statCode,            
            string userId,            
            string? additionalKey            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems";

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