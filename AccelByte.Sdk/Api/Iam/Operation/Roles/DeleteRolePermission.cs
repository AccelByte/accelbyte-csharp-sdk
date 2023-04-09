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
    /// DeleteRolePermission
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ROLE:ADMIN [UPDATE]' or 'ADMIN:ROLE [UPDATE]'
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/roles/{roleId}/permissions/{resource}/{action} [DELETE]
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v4/admin/roles/{roleId}/permissions [DELETE]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteRolePermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRolePermissionBuilder Builder { get => new DeleteRolePermissionBuilder(); }

        public class DeleteRolePermissionBuilder
            : OperationBuilder<DeleteRolePermissionBuilder>
        {





            internal DeleteRolePermissionBuilder() { }






            public DeleteRolePermission Build(
                long action,
                string resource,
                string roleId
            )
            {
                DeleteRolePermission op = new DeleteRolePermission(this,
                    action,
                    resource,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteRolePermission(DeleteRolePermissionBuilder builder,
            long action,
            string resource,
            string roleId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteRolePermission(
            long action,
            string resource,
            string roleId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/permissions/{resource}/{action}";

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