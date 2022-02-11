using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteUserStatItems_2
    ///
    /// Delete user's stat items for given namespace, statCode, and user Id. If query
    /// param *additionalKey* is provided, it will delete user stat items of specific
    /// key (i.e. characterName). Otherwise, it will delete all stat items related to
    /// the user Id.
    /// Delete user's statItems given stat code.
    /// Other detail info:
    /// 
    ///                   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=8 (DELETE)
    ///                   *  Returns : no content
    /// </summary>
    public class DeleteUserStatItems2 : AccelByte.Sdk.Core.Operation
    {
        public DeleteUserStatItems2(
            string namespace_,            
            string statCode,            
            string userId,            
            string? additionalKey            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (additionalKey != null) QueryParams["additionalKey"] = additionalKey;
            
            
            
            
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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