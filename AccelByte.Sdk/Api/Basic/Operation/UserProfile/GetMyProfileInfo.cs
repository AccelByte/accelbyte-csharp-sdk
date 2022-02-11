using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getMyProfileInfo
    ///
    /// Get my profile
    ///  Client with user token can get user profile in target namespace
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=2 (READ)
    ///   *  Action code : 11403
    ///   *  Returns : user profile
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher user profile
    ///     * can be filled with game namespace in order to get game user profile
    ///   *  Language : allowed format: en, en-US
    ///   *  Timezone : IANA time zone, e.g. Asia/Shanghai
    /// </summary>
    public class GetMyProfileInfo : AccelByte.Sdk.Core.Operation
    {
        public GetMyProfileInfo(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserProfilePrivateInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}