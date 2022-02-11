using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// updateMyZipCode
    ///
    /// Update my zip code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=4 (UPDATE)
    ///   *  Action code : 11408
    ///   *  Returns : user zip code
    /// </summary>
    public class UpdateMyZipCode : AccelByte.Sdk.Core.Operation
    {
        public UpdateMyZipCode(
            string namespace_,            
            Model.UserZipCodeUpdate userZipCodeUpdate            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = userZipCodeUpdate;
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles/zipCode";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserZipCode? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserZipCode>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserZipCode>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}