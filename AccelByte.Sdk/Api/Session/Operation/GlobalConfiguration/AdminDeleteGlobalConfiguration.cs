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
    /// adminDeleteGlobalConfiguration
    ///
    /// Delete of global configuration data.
    /// </summary>
    public class AdminDeleteGlobalConfiguration : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteGlobalConfigurationBuilder Builder { get => new AdminDeleteGlobalConfigurationBuilder(); }

        public class AdminDeleteGlobalConfigurationBuilder
            : OperationBuilder<AdminDeleteGlobalConfigurationBuilder>
        {





            internal AdminDeleteGlobalConfigurationBuilder() { }






            public AdminDeleteGlobalConfiguration Build(
            )
            {
                AdminDeleteGlobalConfiguration op = new AdminDeleteGlobalConfiguration(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminDeleteGlobalConfiguration(AdminDeleteGlobalConfigurationBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteGlobalConfiguration(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/global-configurations";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public string? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<string>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<string>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<string>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}