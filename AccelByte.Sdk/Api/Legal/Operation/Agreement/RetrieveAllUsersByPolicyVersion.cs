using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveAllUsersByPolicyVersion
    ///
    /// This API will return all users who has accepted a specific policy
    /// version.Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAllUsersByPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        public RetrieveAllUsersByPolicyVersion(
            string? keyword,            
            int? limit,            
            int? offset,            
            string policyVersionId            
        )
        {
            
            if (keyword != null) QueryParams["keyword"] = keyword;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (policyVersionId != null) QueryParams["policyVersionId"] = policyVersionId;
            
            
            
            
        }

        public override string Path => "/agreement/admin/agreements/policy-versions/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.PagedRetrieveUserAcceptedAgreementResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PagedRetrieveUserAcceptedAgreementResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PagedRetrieveUserAcceptedAgreementResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}