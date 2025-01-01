// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// DeleteSecretV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:SECRET [DELETE]`
    /// 
    /// Delete an environment secret.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteSecretV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSecretV1Builder Builder { get => new DeleteSecretV1Builder(); }

        public class DeleteSecretV1Builder
            : OperationBuilder<DeleteSecretV1Builder>
        {





            internal DeleteSecretV1Builder() { }






            public DeleteSecretV1 Build(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteSecretV1 op = new DeleteSecretV1(this,
                    app,
                    configId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteSecretV1(DeleteSecretV1Builder builder,
            string app,
            string configId,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["configId"] = configId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSecretV1(
            string app,
            string configId,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["configId"] = configId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}";

        public override HttpMethod Method => HttpMethod.Delete;

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