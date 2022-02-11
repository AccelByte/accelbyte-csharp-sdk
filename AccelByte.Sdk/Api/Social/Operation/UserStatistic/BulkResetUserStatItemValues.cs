using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkResetUserStatItemValues
    ///
    /// Bulk reset user's statitem values for given namespace and user. Other detail
    /// info: + *Required permission*:
    /// resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4
    /// (UPDATE) + *Returns*: bulk updated result
    /// </summary>
    public class BulkResetUserStatItemValues : AccelByte.Sdk.Core.Operation
    {
        public BulkResetUserStatItemValues(
            string namespace_,            
            string userId,            
            string? additionalKey,            
            List<Model.ADTOObjectForResettingUserStatItems> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.BulkStatItemOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatItemOperationResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatItemOperationResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}