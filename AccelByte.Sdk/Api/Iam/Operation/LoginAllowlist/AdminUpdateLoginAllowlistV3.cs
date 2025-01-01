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
    /// AdminUpdateLoginAllowlistV3
    ///
    /// This endpoint update login allowlist configuration from specific game namespace.
    /// roleIds: are list of role that allowed to login
    /// Note: only accept game namespace
    /// </summary>
    public class AdminUpdateLoginAllowlistV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateLoginAllowlistV3Builder Builder { get => new AdminUpdateLoginAllowlistV3Builder(); }

        public class AdminUpdateLoginAllowlistV3Builder
            : OperationBuilder<AdminUpdateLoginAllowlistV3Builder>
        {





            internal AdminUpdateLoginAllowlistV3Builder() { }






            public AdminUpdateLoginAllowlistV3 Build(
                ModelLoginAllowlistRequest body,
                string namespace_
            )
            {
                AdminUpdateLoginAllowlistV3 op = new AdminUpdateLoginAllowlistV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateLoginAllowlistV3(AdminUpdateLoginAllowlistV3Builder builder,
            ModelLoginAllowlistRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateLoginAllowlistV3(
            string namespace_,
            Model.ModelLoginAllowlistRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/loginAllowlist";

        public override HttpMethod Method => HttpMethod.Put;

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