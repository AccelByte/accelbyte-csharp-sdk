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
    /// AdminUpdateRoleV4
    ///
    /// Update role request body:
    /// - roleName: specify role name, alphanumeric, cannot have special character (required)
    /// - adminRole: specify if role is for admin user (default false)
    /// - isWildcard: specify if role can be assigned to wildcard (*) namespace (default false)
    /// - deletable: specify if role can be deleted (optional)
    /// 
    /// action code: 10402
    /// </summary>
    public class AdminUpdateRoleV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateRoleV4Builder Builder { get => new AdminUpdateRoleV4Builder(); }

        public class AdminUpdateRoleV4Builder
            : OperationBuilder<AdminUpdateRoleV4Builder>
        {





            internal AdminUpdateRoleV4Builder() { }






            public AdminUpdateRoleV4 Build(
                ModelRoleV4Request body,
                string roleId
            )
            {
                AdminUpdateRoleV4 op = new AdminUpdateRoleV4(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateRoleV4(AdminUpdateRoleV4Builder builder,
            ModelRoleV4Request body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateRoleV4(
            string roleId,
            Model.ModelRoleV4Request body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelRoleV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}