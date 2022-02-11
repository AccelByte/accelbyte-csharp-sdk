using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicCreateUserV4
    ///
    /// Create a new user with unique email address and username.
    /// 
    /// Required attributes: - authType: possible value is EMAILPASSWD -
    /// emailAddress: 5 to 254 characters - username: 3 to 48 characters, case
    /// insensitive, alphanumeric with allowed symbols underscore (_) and dot (.) -
    /// password: 8 to 32 characters, satisfy at least 3 out of 4
    /// conditions(uppercase, lowercase letters, numbers and special characters) and
    /// should not have more than 2 equal characters in a row. - country: ISO3166-1
    /// alpha-2 two letter, e.g. US. - dateOfBirth: YYYY-MM-DD, e.g. 1990-01-01.
    /// valid values are between 1905-01-01 until current date.
    /// Not required attributes: - displayName: 1 to 48 characters
    /// 
    /// This endpoint support accepting agreements for the created user. Supply the
    /// accepted agreements in acceptedPolicies attribute.
    /// </summary>
    public class PublicCreateUserV4 : AccelByte.Sdk.Core.Operation
    {
        public PublicCreateUserV4(
            string namespace_,            
            Model.AccountCreateUserRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountCreateUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}