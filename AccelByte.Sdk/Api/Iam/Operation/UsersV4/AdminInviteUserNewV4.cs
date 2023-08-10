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
    /// AdminInviteUserNewV4
    ///
    /// Required permission 'ADMIN:USER:INVITE [CREATE]
    /// 
    /// Use this endpoint to invite admin or non-admin user and assign role to them. The role must be scoped to namespace. An admin user can only
    /// assign role with namespaces that the admin user has required permission which is same as the required permission of endpoint: [AdminAddUserRoleV4].
    /// 
    /// Detail request body :
    /// - Email Address is required, List of email addresses that will be invited
    /// - isAdmin is required, true if user is admin, false if user is not admin
    /// - Namespace is optional. Only works on multi tenant mode,
    /// if not specified then it will be assigned Publisher namespace,
    /// if specified, it will become that studio/publisher where user is invited to.
    /// - Role is optional, if not specified then it will only assign User role.
    /// - Assigned Namespaces is optional, List of namespaces which the Role will be assigned to the user, only works when Role is not empty.
    /// 
    /// The invited admin will also assigned with "User" role by default.
    /// </summary>
    public class AdminInviteUserNewV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminInviteUserNewV4Builder Builder { get => new AdminInviteUserNewV4Builder(); }

        public class AdminInviteUserNewV4Builder
            : OperationBuilder<AdminInviteUserNewV4Builder>
        {





            internal AdminInviteUserNewV4Builder() { }






            public AdminInviteUserNewV4 Build(
                ModelInviteUserRequestV4 body
            )
            {
                AdminInviteUserNewV4 op = new AdminInviteUserNewV4(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminInviteUserNewV4(AdminInviteUserNewV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminInviteUserNewV4(
            Model.ModelInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelInviteUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}