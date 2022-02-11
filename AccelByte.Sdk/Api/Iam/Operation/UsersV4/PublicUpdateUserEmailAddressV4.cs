using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicUpdateUserEmailAddressV4
    ///
    /// 
    /// 
    /// The endpoint to update my email address.
    /// 
    /// It requires a verification code from
    /// 
    /// 
    ///                                                                                                 /users/me/code/request
    /// 
    /// with UpdateEmailAddress context.
    /// </summary>
    public class PublicUpdateUserEmailAddressV4 : AccelByte.Sdk.Core.Operation
    {
        public PublicUpdateUserEmailAddressV4(
            string namespace_,            
            Model.ModelEmailUpdateRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/email";

        public override HttpMethod Method => HttpMethod.Put;

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