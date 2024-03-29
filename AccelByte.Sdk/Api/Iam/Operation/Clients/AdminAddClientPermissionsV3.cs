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
    /// AdminAddClientPermissionsV3
    ///
    /// **Note for Multi Tenant Mode:**
    /// This is for super admin only.
    /// action code: 10303
    /// </summary>
    public class AdminAddClientPermissionsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddClientPermissionsV3Builder Builder { get => new AdminAddClientPermissionsV3Builder(); }

        public class AdminAddClientPermissionsV3Builder
            : OperationBuilder<AdminAddClientPermissionsV3Builder>
        {





            internal AdminAddClientPermissionsV3Builder() { }






            public AdminAddClientPermissionsV3 Build(
                AccountcommonClientPermissionsV3 body,
                string clientId,
                string namespace_
            )
            {
                AdminAddClientPermissionsV3 op = new AdminAddClientPermissionsV3(this,
                    body,
                    clientId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminAddClientPermissionsV3(AdminAddClientPermissionsV3Builder builder,
            AccountcommonClientPermissionsV3 body,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddClientPermissionsV3(
            string clientId,
            string namespace_,
            Model.AccountcommonClientPermissionsV3 body
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions";

        public override HttpMethod Method => HttpMethod.Post;

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