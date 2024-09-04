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
    /// AdminGetRoleOverrideConfigV3
    ///
    /// Get role override config.
    /// This API has upsert behavior, if there is no config yet, it will create a new one with inactive status.
    /// </summary>
    public class AdminGetRoleOverrideConfigV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleOverrideConfigV3Builder Builder { get => new AdminGetRoleOverrideConfigV3Builder(); }

        public class AdminGetRoleOverrideConfigV3Builder
            : OperationBuilder<AdminGetRoleOverrideConfigV3Builder>
        {





            internal AdminGetRoleOverrideConfigV3Builder() { }






            public AdminGetRoleOverrideConfigV3 Build(
                string namespace_,
                AdminGetRoleOverrideConfigV3Identity identity
            )
            {
                AdminGetRoleOverrideConfigV3 op = new AdminGetRoleOverrideConfigV3(this,
                    namespace_,
                    identity
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetRoleOverrideConfigV3(AdminGetRoleOverrideConfigV3Builder builder,
            string namespace_,
            AdminGetRoleOverrideConfigV3Identity identity
        )
        {
            PathParams["namespace"] = namespace_;

            if (identity is not null) QueryParams["identity"] = identity.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRoleOverrideConfigV3(
            string namespace_,
            AdminGetRoleOverrideConfigV3Identity identity
        )
        {
            PathParams["namespace"] = namespace_;

            if (identity is not null) QueryParams["identity"] = identity.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/roleoverride";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelRoleOverrideResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelRoleOverrideResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelRoleOverrideResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleOverrideResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminGetRoleOverrideConfigV3Identity : StringEnum<AdminGetRoleOverrideConfigV3Identity>
    {
        public static readonly AdminGetRoleOverrideConfigV3Identity GAMEADMIN
            = new AdminGetRoleOverrideConfigV3Identity("GAME_ADMIN");

        public static readonly AdminGetRoleOverrideConfigV3Identity USER
            = new AdminGetRoleOverrideConfigV3Identity("USER");

        public static readonly AdminGetRoleOverrideConfigV3Identity VIEWONLY
            = new AdminGetRoleOverrideConfigV3Identity("VIEW_ONLY");


        public static implicit operator AdminGetRoleOverrideConfigV3Identity(string value)
        {
            return NewValue(value);
        }

        public AdminGetRoleOverrideConfigV3Identity(string enumValue)
            : base(enumValue)
        {

        }
    }

}