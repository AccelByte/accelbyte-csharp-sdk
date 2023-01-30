// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getGroupInviteRequestPublicV2
    ///
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP:JOIN [READ]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to Get Group Invite Request List
    /// 
    /// 
    /// 
    /// 
    /// Get Group Invite Request List for specific group. Group members needs to have permission and also belong to the group to access this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73501
    /// </summary>
    public class GetGroupInviteRequestPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupInviteRequestPublicV2Builder Builder = new GetGroupInviteRequestPublicV2Builder();

        public class GetGroupInviteRequestPublicV2Builder
            : OperationBuilder<GetGroupInviteRequestPublicV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetGroupInviteRequestPublicV2Builder() { }


            public GetGroupInviteRequestPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupInviteRequestPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetGroupInviteRequestPublicV2 Build(
                string groupId,
                string namespace_
            )
            {
                GetGroupInviteRequestPublicV2 op = new GetGroupInviteRequestPublicV2(this,
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetGroupInviteRequestPublicV2(GetGroupInviteRequestPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGroupInviteRequestPublicV2(
            string groupId,            
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/invite/request";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetMemberRequestsListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}