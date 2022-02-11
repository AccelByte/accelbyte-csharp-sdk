using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveLatestPoliciesPublic
    ///
    /// Retrieve all active latest policies based on a namespace and country. The
    /// country will be read from user token.
    /// Other detail info:
    /// 
    ///   * Leave the policyType empty if you want to be responded with all policy type
    ///   *  Fill the tags if you want to filter the responded policy by tags
    ///   *  Fill the defaultOnEmpty with true if you want to be responded with default country-specific policy if your requested country is not exist
    ///   *  Fill the alwaysIncludeDefault with true if you want to be responded with always include default policy. If there are duplicate policies (default policies and country specific policies with same base policy) it'll include policy with same country code, for example:
    ///     * Document 1 (default): Region US (default), UA
    ///     * Document 2 (default): Region US (default)
    ///     * Document 3 (default): Region US (default)
    ///     * User: Region UA
    ///     * Query: alwaysIncludeDefault: true
    ///     * Response: Document 1 (UA), Document 2 (US), Document 3 (US)
    ///   *  Required permission: login user
    /// </summary>
    public class RetrieveLatestPoliciesPublic : AccelByte.Sdk.Core.Operation
    {
        public RetrieveLatestPoliciesPublic(
            string namespace_,            
            bool? alwaysIncludeDefault,            
            bool? defaultOnEmpty,            
            string? policyType,            
            string? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (alwaysIncludeDefault != null) QueryParams["alwaysIncludeDefault"] = Convert.ToString(alwaysIncludeDefault)!;
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (policyType != null) QueryParams["policyType"] = policyType;
            if (tags != null) QueryParams["tags"] = tags;
            
            
            
            
        }

        public override string Path => "/agreement/public/policies/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RetrievePolicyPublicResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}