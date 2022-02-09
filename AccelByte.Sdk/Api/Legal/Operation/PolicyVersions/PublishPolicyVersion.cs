using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class PublishPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        public PublishPolicyVersion(
            string policyVersionId,            
            bool? shouldNotify            
        )
        {
            PathParams["policyVersionId"] = policyVersionId;
            
            if (shouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(shouldNotify)!;
            
            
            
            
        }

        public override string Path => "/agreement/admin/policies/versions/{policyVersionId}/latest";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}