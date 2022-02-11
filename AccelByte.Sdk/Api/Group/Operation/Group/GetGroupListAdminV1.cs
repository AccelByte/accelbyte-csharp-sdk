using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getGroupListAdminV1
    ///
    /// 
    /// 
    /// Required Permission: "ADMIN:NAMESPACE:{namespace}:GROUP [READ]"
    /// 
    /// Get list of groups. This endpoint will show any types of group
    /// 
    /// Action Code: 73301
    /// </summary>
    public class GetGroupListAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public GetGroupListAdminV1(
            string namespace_,            
            string? configurationCode,            
            string? groupName,            
            string? groupRegion,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (configurationCode != null) QueryParams["configurationCode"] = configurationCode;
            if (groupName != null) QueryParams["groupName"] = groupName;
            if (groupRegion != null) QueryParams["groupRegion"] = groupRegion;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetGroupsListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsListResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}