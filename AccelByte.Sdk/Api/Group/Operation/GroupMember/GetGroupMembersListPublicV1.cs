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
    /// getGroupMembersListPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to get list of group members.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73410
    /// </summary>
    public class GetGroupMembersListPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public GetGroupMembersListPublicV1(
            string groupId,            
            string namespace_,            
            long? limit,            
            long? offset,            
            string? order            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order != null) QueryParams["order"] = order;
            
            
            
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/members";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetGroupMemberListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupMemberListResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}