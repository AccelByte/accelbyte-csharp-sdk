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
    /// getGroupJoinRequestPublicV1
    ///
    /// 
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
    /// This endpoint is used to Get Group Join Request List
    /// 
    /// 
    /// 
    /// 
    /// Get Group Join Request List for specific group. Group members needs to have permission and also belong to the group to access this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73501
    /// </summary>
    public class GetGroupJoinRequestPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGroupJoinRequestPublicV1Builder Builder = new GetGroupJoinRequestPublicV1Builder();

        public class GetGroupJoinRequestPublicV1Builder
            : OperationBuilder<GetGroupJoinRequestPublicV1Builder>
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetGroupJoinRequestPublicV1Builder() { }


            public GetGroupJoinRequestPublicV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetGroupJoinRequestPublicV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetGroupJoinRequestPublicV1 Build(
                string groupId,
                string namespace_
            )
            {
                GetGroupJoinRequestPublicV1 op = new GetGroupJoinRequestPublicV1(this,
                    groupId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetGroupJoinRequestPublicV1(GetGroupJoinRequestPublicV1Builder builder,
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

        public GetGroupJoinRequestPublicV1(
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

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/join/request";

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