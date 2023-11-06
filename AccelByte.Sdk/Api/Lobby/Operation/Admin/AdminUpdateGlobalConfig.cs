// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminUpdateGlobalConfig
    ///
    /// Upsert global configuration data.
    /// </summary>
    public class AdminUpdateGlobalConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateGlobalConfigBuilder Builder { get => new AdminUpdateGlobalConfigBuilder(); }

        public class AdminUpdateGlobalConfigBuilder
            : OperationBuilder<AdminUpdateGlobalConfigBuilder>
        {





            internal AdminUpdateGlobalConfigBuilder() { }






            public AdminUpdateGlobalConfig Build(
                ModelPutGlobalConfigurationRequest body
            )
            {
                AdminUpdateGlobalConfig op = new AdminUpdateGlobalConfig(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminUpdateGlobalConfig(AdminUpdateGlobalConfigBuilder builder,
            ModelPutGlobalConfigurationRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateGlobalConfig(
            Model.ModelPutGlobalConfigurationRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/global-configurations";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelGlobalConfiguration? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelGlobalConfiguration>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelGlobalConfiguration>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGlobalConfiguration>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}