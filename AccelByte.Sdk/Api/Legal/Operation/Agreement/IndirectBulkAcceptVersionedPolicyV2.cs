using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// indirectBulkAcceptVersionedPolicyV2
    ///
    ///  IMPORTANT: GOING TO DEPRECATE
    /// 
    /// Accepts many legal policy versions all at once. Supply with localized version
    /// policy id, version policy id, policy id, userId, namespace, country code and
    /// client id to accept an agreement. This endpoint used by APIGateway during new
    /// user registration.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:LEGAL", action=1 (CREATE)
    /// </summary>
    public class IndirectBulkAcceptVersionedPolicyV2 : AccelByte.Sdk.Core.Operation
    {
        public IndirectBulkAcceptVersionedPolicyV2(
            string clientId,            
            string countryCode,            
            string namespace_,            
            string userId,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/public/agreements/policies/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AcceptAgreementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}