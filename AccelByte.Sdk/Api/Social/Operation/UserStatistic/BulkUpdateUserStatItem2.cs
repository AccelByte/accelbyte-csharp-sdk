using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkUpdateUserStatItem_2
    ///
    /// Public bulk update user's statitems value for given namespace and user with
    /// specific update strategy. There are four supported update strategies: +
    /// *OVERRIDE*: update user statitem with the new value + *INCREMENT*: increment
    /// user statitem with the specified value + *MAX*: update user statitem with the
    /// specified value if it's larger than the existing value + *MIN*: update user
    /// statitem with the specified value if it's lower than the existing value The
    /// *additionalKey* parameter will be suffixed to *userId* and is used to support
    /// multi level user's statitems, such as character's statitems. If provided,
    /// user's statitems will be saved with key: *userId_additionalKey* Other detail
    /// info: + *Required permission*:
    /// resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE) +
    /// *Returns*: bulk updated result
    /// </summary>
    public class BulkUpdateUserStatItem2 : AccelByte.Sdk.Core.Operation
    {
        public BulkUpdateUserStatItem2(
            string namespace_,            
            string userId,            
            string? additionalKey,            
            List<Model.BulkStatItemUpdate> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v2/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

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