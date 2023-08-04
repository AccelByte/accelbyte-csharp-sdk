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
    /// GetRoleAdminStatus
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ROLE [READ]
    /// 
    /// 
    /// Admin roles has its members listed in the role.
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///           * Substitute endpoint: /iam/v3/admin/roles/{roleId}/admin [GET]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetRoleAdminStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRoleAdminStatusBuilder Builder { get => new GetRoleAdminStatusBuilder(); }

        public class GetRoleAdminStatusBuilder
            : OperationBuilder<GetRoleAdminStatusBuilder>
        {





            internal GetRoleAdminStatusBuilder() { }






            public GetRoleAdminStatus Build(
                string roleId
            )
            {
                GetRoleAdminStatus op = new GetRoleAdminStatus(this,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetRoleAdminStatus(GetRoleAdminStatusBuilder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public GetRoleAdminStatus(
            string roleId
        )
        {
            PathParams["roleId"] = roleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/roles/{roleId}/admin";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public Model.ModelRoleAdminStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleAdminStatusResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}