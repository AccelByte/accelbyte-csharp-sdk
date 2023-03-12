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
    /// RemoveRoleManagers
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission Required permission 'ROLE:ADMIN [UPDATE]' or 'ADMIN:ROLE [UPDATE]'
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/roles/{roleId}/managers [DELETE]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class RemoveRoleManagers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RemoveRoleManagersBuilder Builder { get => new RemoveRoleManagersBuilder(); }

        public class RemoveRoleManagersBuilder
            : OperationBuilder<RemoveRoleManagersBuilder>
        {





            internal RemoveRoleManagersBuilder() { }






            public RemoveRoleManagers Build(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                RemoveRoleManagers op = new RemoveRoleManagers(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RemoveRoleManagers(RemoveRoleManagersBuilder builder,
            ModelRoleManagersRequest body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RemoveRoleManagers(
            string roleId,
            Model.ModelRoleManagersRequest body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/managers";

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