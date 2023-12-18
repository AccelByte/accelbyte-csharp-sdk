// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminRemoveRoleMembersV3
    ///
    /// Admin roles has its members listed in the role.
    /// Role can only be assigned to other users by the role's manager.
    /// action code: 10411
    /// </summary>
    public class AdminRemoveRoleMembersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRemoveRoleMembersV3Builder Builder { get => new AdminRemoveRoleMembersV3Builder(); }

        public class AdminRemoveRoleMembersV3Builder
            : OperationBuilder<AdminRemoveRoleMembersV3Builder>
        {





            internal AdminRemoveRoleMembersV3Builder() { }






            public AdminRemoveRoleMembersV3 Build(
                ModelRoleMembersRequestV3 body,
                string roleId
            )
            {
                AdminRemoveRoleMembersV3 op = new AdminRemoveRoleMembersV3(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminRemoveRoleMembersV3(AdminRemoveRoleMembersV3Builder builder,
            ModelRoleMembersRequestV3 body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRemoveRoleMembersV3(
            string roleId,
            Model.ModelRoleMembersRequestV3 body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/members";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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