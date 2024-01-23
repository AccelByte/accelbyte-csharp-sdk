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
    /// AdminUpdateUserRoleV4
    ///
    /// User's roles will be replaced with roles from request body.
    /// An admin user can only assign role with **assignedNamespaces** if the admin user has required permission which is same as the required permission of this endpoint.
    /// </summary>
    public class AdminUpdateUserRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserRoleV4Builder Builder { get => new AdminUpdateUserRoleV4Builder(); }

        public class AdminUpdateUserRoleV4Builder
            : OperationBuilder<AdminUpdateUserRoleV4Builder>
        {





            internal AdminUpdateUserRoleV4Builder() { }






            public AdminUpdateUserRoleV4 Build(
                ModelAddUserRoleV4Request body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserRoleV4 op = new AdminUpdateUserRoleV4(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateUserRoleV4(AdminUpdateUserRoleV4Builder builder,
            ModelAddUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateUserRoleV4(
            string namespace_,
            string userId,
            Model.ModelAddUserRoleV4Request body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListUserRolesV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}