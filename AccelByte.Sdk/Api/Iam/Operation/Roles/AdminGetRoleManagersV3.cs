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
    /// AdminGetRoleManagersV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// 
    /// 
    /// action code: 10415
    /// </summary>
    public class AdminGetRoleManagersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleManagersV3Builder Builder { get => new AdminGetRoleManagersV3Builder(); }

        public class AdminGetRoleManagersV3Builder
            : OperationBuilder<AdminGetRoleManagersV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal AdminGetRoleManagersV3Builder() { }


            public AdminGetRoleManagersV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminGetRoleManagersV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminGetRoleManagersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public AdminGetRoleManagersV3 Build(
                string roleId
            )
            {
                AdminGetRoleManagersV3 op = new AdminGetRoleManagersV3(this,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetRoleManagersV3(AdminGetRoleManagersV3Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public AdminGetRoleManagersV3(
            string roleId,
            string? after,
            string? before,
            long? limit
        )
        {
            PathParams["roleId"] = roleId;

            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/managers";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public Model.ModelRoleManagersResponsesV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelRoleManagersResponsesV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelRoleManagersResponsesV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleManagersResponsesV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}