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
    /// deleteMemberRolePublicV2
    ///
    /// Required Member Role Permission: "GROUP:ROLE [UPDATE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to remove role from group member
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73204
    /// </summary>
    public class DeleteMemberRolePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMemberRolePublicV2Builder Builder { get => new DeleteMemberRolePublicV2Builder(); }

        public class DeleteMemberRolePublicV2Builder
            : OperationBuilder<DeleteMemberRolePublicV2Builder>
        {





            internal DeleteMemberRolePublicV2Builder() { }






            public DeleteMemberRolePublicV2 Build(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string groupId,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV2 op = new DeleteMemberRolePublicV2(this,
                    body,
                    groupId,
                    memberRoleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteMemberRolePublicV2(DeleteMemberRolePublicV2Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string groupId,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMemberRolePublicV2(
            string groupId,
            string memberRoleId,
            string namespace_,
            Model.ModelsRemoveRoleFromMemberRequestV1 body
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/roles/{memberRoleId}/groups/{groupId}/members";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}