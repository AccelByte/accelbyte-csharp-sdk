using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicUserVerificationV3
    ///
    /// 
    /// 
    /// Required valid user authorization
    /// 
    /// Redeems a verification code sent to a user to verify the user's contact
    /// address is correct
    /// 
    /// Available ContactType : email
    /// 
    /// action code: 10107
    /// </summary>
    public class PublicUserVerificationV3 : AccelByte.Sdk.Core.Operation
    {
        public PublicUserVerificationV3(
            string namespace_,            
            Model.ModelUserVerificationRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

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