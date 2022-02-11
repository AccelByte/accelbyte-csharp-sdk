using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// CheckUserAvailability
    ///
    /// Check user's account availability. Available field : - displayName If request
    /// include access token with user ID data, that user ID will be excluded from
    /// availability check. For example, in case user update his emailAddress, he can
    /// use his own emailAddress to update his account. Response Code : - Account
    /// Available : 404 (not found) - Account Not Available : 204 (no content)
    /// </summary>
    public class CheckUserAvailability : AccelByte.Sdk.Core.Operation
    {
        public CheckUserAvailability(
            string namespace_,            
            string field,            
            string query            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (field != null) QueryParams["field"] = field;
            if (query != null) QueryParams["query"] = query;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/availability";

        public override HttpMethod Method => HttpMethod.Get;

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