// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetServicesConfiguration
    ///
    /// Get Registered Services Configuration.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:GDPR:CONFIGURATION [READ]` and scope `account`
    /// </summary>
    public class AdminGetServicesConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetServicesConfigurationBuilder Builder { get => new AdminGetServicesConfigurationBuilder(); }

        public class AdminGetServicesConfigurationBuilder
            : OperationBuilder<AdminGetServicesConfigurationBuilder>
        {





            internal AdminGetServicesConfigurationBuilder() { }






            public AdminGetServicesConfiguration Build(
                string namespace_
            )
            {
                AdminGetServicesConfiguration op = new AdminGetServicesConfiguration(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetServicesConfiguration(AdminGetServicesConfigurationBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetServicesConfiguration(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/services/configurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.DtoServicesConfigurationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.DtoServicesConfigurationResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.DtoServicesConfigurationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DtoServicesConfigurationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}