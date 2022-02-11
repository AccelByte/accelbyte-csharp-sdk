using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// updateUserStatItemValue_1
    ///
    /// Public update user's statitem value for a given namespace and user with a
    /// certain update strategy. There are four supported update strategies: +
    /// *OVERRIDE*: update user statitem with the new value + *INCREMENT*: increment
    /// user statitem with the specified value + *MAX*: update user statitem with the
    /// specified value if it's larger than the existing value + *MIN*: update user
    /// statitem with the specified value if it's lower than the existing value The
    /// *additionalKey* parameter will be suffixed to *userId* and is used to support
    /// multi level user's statitems, such as character's statitems. If provided,
    /// user's statitems will be saved with key: *userId_additionalKey* Other detail
    /// info: + *Required permission*:
    /// resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE) +
    /// *Returns*: updated user's statItem
    /// </summary>
    public class UpdateUserStatItemValue1 : AccelByte.Sdk.Core.Operation
    {
        public UpdateUserStatItemValue1(
            string namespace_,            
            string statCode,            
            string userId,            
            string? additionalKey,            
            Model.StatItemUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/social/v2/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}