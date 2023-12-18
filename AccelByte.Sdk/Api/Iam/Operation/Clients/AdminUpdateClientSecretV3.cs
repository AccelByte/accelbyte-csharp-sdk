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
    /// AdminUpdateClientSecretV3
    ///
    /// Update Client Secret
    /// </summary>
    public class AdminUpdateClientSecretV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateClientSecretV3Builder Builder { get => new AdminUpdateClientSecretV3Builder(); }

        public class AdminUpdateClientSecretV3Builder
            : OperationBuilder<AdminUpdateClientSecretV3Builder>
        {





            internal AdminUpdateClientSecretV3Builder() { }






            public AdminUpdateClientSecretV3 Build(
                ClientmodelV3ClientUpdateSecretRequest body,
                string clientId,
                string namespace_
            )
            {
                AdminUpdateClientSecretV3 op = new AdminUpdateClientSecretV3(this,
                    body,
                    clientId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminUpdateClientSecretV3(AdminUpdateClientSecretV3Builder builder,
            ClientmodelV3ClientUpdateSecretRequest body,
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

        public AdminUpdateClientSecretV3(
            string clientId,
            string namespace_,
            Model.ClientmodelV3ClientUpdateSecretRequest body
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/{clientId}/secret";

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