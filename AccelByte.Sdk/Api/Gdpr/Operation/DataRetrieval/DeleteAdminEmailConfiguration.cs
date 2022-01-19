using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    public class DeleteAdminEmailConfiguration : AccelByte.Sdk.Core.Operation
    {
        public DeleteAdminEmailConfiguration(
            string namespace_,            
            List<string> emails            
        )
        {
            PathParams["namespace"] = namespace_;
            
            QueryParams["emails"] = Convert.ToString(emails)!;
            
            
            
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/emails/configurations";

        public override HttpMethod Method => HttpMethod.Delete;

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