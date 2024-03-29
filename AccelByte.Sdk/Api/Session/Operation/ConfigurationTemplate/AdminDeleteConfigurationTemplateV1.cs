// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminDeleteConfigurationTemplateV1
    ///
    /// Delete a template configuration.
    /// </summary>
    public class AdminDeleteConfigurationTemplateV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteConfigurationTemplateV1Builder Builder { get => new AdminDeleteConfigurationTemplateV1Builder(); }

        public class AdminDeleteConfigurationTemplateV1Builder
            : OperationBuilder<AdminDeleteConfigurationTemplateV1Builder>
        {





            internal AdminDeleteConfigurationTemplateV1Builder() { }






            public AdminDeleteConfigurationTemplateV1 Build(
                string name,
                string namespace_
            )
            {
                AdminDeleteConfigurationTemplateV1 op = new AdminDeleteConfigurationTemplateV1(this,
                    name,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDeleteConfigurationTemplateV1(AdminDeleteConfigurationTemplateV1Builder builder,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteConfigurationTemplateV1(
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configurations/{name}";

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