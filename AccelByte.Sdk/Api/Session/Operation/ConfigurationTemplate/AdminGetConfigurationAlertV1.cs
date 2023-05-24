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
    /// adminGetConfigurationAlertV1
    ///
    /// Get a configuration alert.
    /// </summary>
    public class AdminGetConfigurationAlertV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetConfigurationAlertV1Builder Builder { get => new AdminGetConfigurationAlertV1Builder(); }

        public class AdminGetConfigurationAlertV1Builder
            : OperationBuilder<AdminGetConfigurationAlertV1Builder>
        {





            internal AdminGetConfigurationAlertV1Builder() { }






            public AdminGetConfigurationAlertV1 Build(
                string namespace_
            )
            {
                AdminGetConfigurationAlertV1 op = new AdminGetConfigurationAlertV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetConfigurationAlertV1(AdminGetConfigurationAlertV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetConfigurationAlertV1(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/alerts-configuration";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsConfigAlertResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigAlertResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigAlertResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}