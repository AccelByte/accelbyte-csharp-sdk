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
    /// AdminListAssignedUsersV4
    ///
    /// Query all users that has the specified role.
    /// action code: 10416
    /// </summary>
    public class AdminListAssignedUsersV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListAssignedUsersV4Builder Builder { get => new AdminListAssignedUsersV4Builder(); }

        public class AdminListAssignedUsersV4Builder
            : OperationBuilder<AdminListAssignedUsersV4Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }





            internal AdminListAssignedUsersV4Builder() { }


            public AdminListAssignedUsersV4Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminListAssignedUsersV4Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminListAssignedUsersV4Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public AdminListAssignedUsersV4 Build(
                string roleId
            )
            {
                AdminListAssignedUsersV4 op = new AdminListAssignedUsersV4(this,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListAssignedUsersV4(AdminListAssignedUsersV4Builder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;

            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListAssignedUsersV4(
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
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListAssignedUsersV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelListAssignedUsersV4Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelListAssignedUsersV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListAssignedUsersV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}