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
    /// rejectGroupJoinRequestPublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP:JOIN [CREATE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to reject group join request.
    /// 
    /// 
    /// 
    /// 
    /// Reject group join request. If specific user is not asked to join the specific group ID, it will show the the error to show if the user is not asked to join yet.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will also check if the specific user is already joined to specific group
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73408
    /// </summary>
    public class RejectGroupJoinRequestPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RejectGroupJoinRequestPublicV2Builder Builder { get => new RejectGroupJoinRequestPublicV2Builder(); }

        public class RejectGroupJoinRequestPublicV2Builder
            : OperationBuilder<RejectGroupJoinRequestPublicV2Builder>
        {





            internal RejectGroupJoinRequestPublicV2Builder() { }






            public RejectGroupJoinRequestPublicV2 Build(
                string groupId,
                string namespace_,
                string userId
            )
            {
                RejectGroupJoinRequestPublicV2 op = new RejectGroupJoinRequestPublicV2(this,
                    groupId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private RejectGroupJoinRequestPublicV2(RejectGroupJoinRequestPublicV2Builder builder,
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RejectGroupJoinRequestPublicV2(
            string groupId,
            string namespace_,
            string userId
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/join/reject";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsMemberRequestGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}