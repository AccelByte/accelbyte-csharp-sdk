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
    /// AdminUpdateServicesConfiguration
    ///
    /// Update Registered Services Configuration.
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:GDPR:CONFIGURATION [UPDATE]` and scope `account`
    /// </summary>
    public class AdminUpdateServicesConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateServicesConfigurationBuilder Builder { get => new AdminUpdateServicesConfigurationBuilder(); }

        public class AdminUpdateServicesConfigurationBuilder
            : OperationBuilder<AdminUpdateServicesConfigurationBuilder>
        {





            internal AdminUpdateServicesConfigurationBuilder() { }






            public AdminUpdateServicesConfiguration Build(
                DtoServiceConfigurationUpdateRequest body,
                string namespace_
            )
            {
                AdminUpdateServicesConfiguration op = new AdminUpdateServicesConfiguration(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminUpdateServicesConfiguration(AdminUpdateServicesConfigurationBuilder builder,
            DtoServiceConfigurationUpdateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateServicesConfiguration(
            string namespace_,
            Model.DtoServiceConfigurationUpdateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/services/configurations";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.DtoServiceConfigurationUpdateRequest? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.DtoServiceConfigurationUpdateRequest>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.DtoServiceConfigurationUpdateRequest>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DtoServiceConfigurationUpdateRequest>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}