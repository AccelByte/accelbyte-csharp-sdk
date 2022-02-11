using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// acceptVersionedPolicy
    ///
    /// Accepts a legal policy version. Supply with localized version policy id to
    /// accept an agreement.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class AcceptVersionedPolicy : AccelByte.Sdk.Core.Operation
    {
        public AcceptVersionedPolicy(
            string localizedPolicyVersionId            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            
            
        }

        public override string Path => "/agreement/public/agreements/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}