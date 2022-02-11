using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// anonymizeUserAgreement
    ///
    /// This API will anonymize agreement record for specified user. Other detail
    /// info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=8 (DELETE)
    /// </summary>
    public class AnonymizeUserAgreement : AccelByte.Sdk.Core.Operation
    {
        public AnonymizeUserAgreement(
            string userId            
        )
        {
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/agreement/admin/users/{userId}/anonymization/agreements";

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