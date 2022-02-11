using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminSearchUserV3
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER [READ]
    /// 
    /// Endpoint behavior :
    /// 
    ///           * by default this endpoint searches all users on the specified namespace
    ///           * if query parameter is defined, endpoint will search users whose email address, display name, username, or third party partially match with the query
    ///           * if startDate and endDate parameters is defined, endpoint will search users which created on the certain date range
    ///           * if query, startDate and endDate parameters are defined, endpoint will search users whose email address and display name match and created on the certain date range
    ///           * if startDate parameter is defined, endpoint will search users that created start from the defined date
    ///           * if endDate parameter is defined, endpoint will search users that created until the defined date
    ///           * if platformId parameter is defined and by parameter is using thirdparty, endpoint will search users based on the platformId they have linked to
    ///           * if platformBy parameter is defined and by parameter is using thirdparty, endpoint will search users based on the platformUserId or platformDisplayName they have linked to, example value: platformUserId or platformDisplayName
    ///           * if limit is not defined, The default limit is 100
    /// 
    /// 
    /// action code : 10133
    /// </summary>
    public class AdminSearchUserV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminSearchUserV3(
            string namespace_,            
            string? by,            
            string? endDate,            
            long? limit,            
            string? offset,            
            string? platformBy,            
            string? platformId,            
            string? query,            
            string? startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (by != null) QueryParams["by"] = by;
            if (endDate != null) QueryParams["endDate"] = endDate;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = offset;
            if (platformBy != null) QueryParams["platformBy"] = platformBy;
            if (platformId != null) QueryParams["platformId"] = platformId;
            if (query != null) QueryParams["query"] = query;
            if (startDate != null) QueryParams["startDate"] = startDate;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelSearchUsersResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}