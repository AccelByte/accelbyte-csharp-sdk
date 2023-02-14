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
    /// updateMemberRoleAdminV1
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [UPDATE]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update member role
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73204
    /// </summary>
    public class UpdateMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMemberRoleAdminV1Builder Builder { get => new UpdateMemberRoleAdminV1Builder(); }

        public class UpdateMemberRoleAdminV1Builder
            : OperationBuilder<UpdateMemberRoleAdminV1Builder>
        {





            internal UpdateMemberRoleAdminV1Builder() { }






            public UpdateMemberRoleAdminV1 Build(
                ModelsUpdateMemberRoleRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                UpdateMemberRoleAdminV1 op = new UpdateMemberRoleAdminV1(this,
                    body,
                    memberRoleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateMemberRoleAdminV1(UpdateMemberRoleAdminV1Builder builder,
            ModelsUpdateMemberRoleRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateMemberRoleAdminV1(
            string memberRoleId,
            string namespace_,
            Model.ModelsUpdateMemberRoleRequestV1 body
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRoleResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRoleResponseV1>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}