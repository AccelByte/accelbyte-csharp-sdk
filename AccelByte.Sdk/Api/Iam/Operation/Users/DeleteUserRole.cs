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
    /// DeleteUserRole
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/users/{userId}/roles/{roleId} [DELETE]
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [DELETE]'
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteUserRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRoleBuilder Builder { get => new DeleteUserRoleBuilder(); }

        public class DeleteUserRoleBuilder
            : OperationBuilder<DeleteUserRoleBuilder>
        {





            internal DeleteUserRoleBuilder() { }






            public DeleteUserRole Build(
                string namespace_,
                string roleId,
                string userId
            )
            {
                DeleteUserRole op = new DeleteUserRole(this,
                    namespace_,
                    roleId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private DeleteUserRole(DeleteUserRoleBuilder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserRole(
            string namespace_,
            string roleId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json", "text/plain" };

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