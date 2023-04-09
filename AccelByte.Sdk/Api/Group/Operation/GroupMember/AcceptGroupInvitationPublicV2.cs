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
    /// acceptGroupInvitationPublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to accept group invitation.
    /// 
    /// 
    /// 
    /// 
    /// Accept group invitation. If specific user is not invited in the specific group ID, it will show the the error to show if the user is not invited yet.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will also check if the user who access this endpoint is already joined to specific group
    /// 
    /// 
    /// 
    /// 
    /// Accessing this endpoint will make all requests (invite / join request) will be deleted for the user who access this endpoint
    /// 
    /// 
    /// 
    /// 
    /// Existing members will receive notification of newly accepted member.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73401
    /// </summary>
    public class AcceptGroupInvitationPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcceptGroupInvitationPublicV2Builder Builder { get => new AcceptGroupInvitationPublicV2Builder(); }

        public class AcceptGroupInvitationPublicV2Builder
            : OperationBuilder<AcceptGroupInvitationPublicV2Builder>
        {





            internal AcceptGroupInvitationPublicV2Builder() { }






            public AcceptGroupInvitationPublicV2 Build(
                string groupId,
                string namespace_
            )
            {
                AcceptGroupInvitationPublicV2 op = new AcceptGroupInvitationPublicV2(this,
                    groupId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AcceptGroupInvitationPublicV2(AcceptGroupInvitationPublicV2Builder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AcceptGroupInvitationPublicV2(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/invite/accept";

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
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}