using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
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
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersResponseWithPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}