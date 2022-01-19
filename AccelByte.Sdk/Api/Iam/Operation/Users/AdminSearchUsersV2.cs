using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AdminSearchUsersV2 : AccelByte.Sdk.Core.Operation
    {
        public AdminSearchUsersV2(
            string namespace_,            
            string? after,            
            string? before,            
            string? displayName,            
            string? limit,            
            string? loginId,            
            string? platformUserId,            
            string? roleId,            
            string? userId,            
            string platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (displayName != null) QueryParams["displayName"] = displayName;
            if (limit != null) QueryParams["limit"] = limit;
            if (loginId != null) QueryParams["loginId"] = loginId;
            if (platformUserId != null) QueryParams["platformUserId"] = platformUserId;
            if (roleId != null) QueryParams["roleId"] = roleId;
            if (userId != null) QueryParams["userId"] = userId;
            if (platformId != null) QueryParams["platformId"] = platformId;
            
            
            
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelSearchUsersByPlatformIDResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersByPlatformIDResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}