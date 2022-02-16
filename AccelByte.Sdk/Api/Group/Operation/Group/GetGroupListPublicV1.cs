// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getGroupListPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Get list of groups. This endpoint will only show OPEN and PUBLIC group type. This endpoint can search based on the group name by filling the "groupName" query parameter
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73303
    /// </summary>
    public class GetGroupListPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public GetGroupListPublicV1(
            string namespace_,            
            string? groupName,            
            string? groupRegion,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (groupName != null) QueryParams["groupName"] = groupName;
            if (groupRegion != null) QueryParams["groupRegion"] = groupRegion;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups";

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