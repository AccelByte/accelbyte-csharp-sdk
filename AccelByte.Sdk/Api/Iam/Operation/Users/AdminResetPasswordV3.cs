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
    /// AdminResetPasswordV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PASSWORD:USER:{userId} [UPDATE]'
    /// </summary>
    public class AdminResetPasswordV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminResetPasswordV3Builder Builder = new AdminResetPasswordV3Builder();

        public class AdminResetPasswordV3Builder
            : OperationBuilder<AdminResetPasswordV3Builder>
        {





            internal AdminResetPasswordV3Builder() { }






            public AdminResetPasswordV3 Build(
                ModelUserPasswordUpdateV3Request body,
                string namespace_,
                string userId
            )
            {
                AdminResetPasswordV3 op = new AdminResetPasswordV3(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminResetPasswordV3(AdminResetPasswordV3Builder builder,
            ModelUserPasswordUpdateV3Request body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminResetPasswordV3(
            string namespace_,
            string userId,
            Model.ModelUserPasswordUpdateV3Request body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/password";

        public override HttpMethod Method => HttpMethod.Put;

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