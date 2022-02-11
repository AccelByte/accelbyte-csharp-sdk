using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// TokenIntrospectionV3
    ///
    /// 
    /// 
    /// This endpoint returns information about an access token intended to be used by
    /// resource servers or other internal servers.
    /// 
    /// This endpoint requires authorized requests header with valid basic or bearer
    /// token.
    /// 
    /// action code : 10705
    /// </summary>
    public class TokenIntrospectionV3 : AccelByte.Sdk.Core.Operation
    {
        public TokenIntrospectionV3(
            string token            
        )
        {
            
            
            if (token != null) FormParams["token"] = token;
            
            
            
        }

        public override string Path => "/iam/v3/oauth/introspect";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OauthmodelTokenIntrospectResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenIntrospectResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenIntrospectResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}