// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminPatchUpdateLogConfig
    ///
    /// 
    /// Update Log Configuration
    /// logLevel use for logging in service, the value can use is trace|debug|info|warning|error|fatal|panic
    /// socketLogEnabled is use for enable socket log
    /// internalAccessLogEnabled is for enabling access log for internal endpoint
    /// logLevelDB use for logging in DB, the value can use is trace|debug|info|warning|error|fatal|panic
    /// slowQueryThreshold use for logging slow threshold in time measure is nano second
    /// </summary>
    public class AdminPatchUpdateLogConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPatchUpdateLogConfigBuilder Builder { get => new AdminPatchUpdateLogConfigBuilder(); }

        public class AdminPatchUpdateLogConfigBuilder
            : OperationBuilder<AdminPatchUpdateLogConfigBuilder>
        {





            internal AdminPatchUpdateLogConfigBuilder() { }






            public AdminPatchUpdateLogConfig Build(
                LogconfigConfiguration body
            )
            {
                AdminPatchUpdateLogConfig op = new AdminPatchUpdateLogConfig(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminPatchUpdateLogConfig(AdminPatchUpdateLogConfigBuilder builder,
            LogconfigConfiguration body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPatchUpdateLogConfig(
            Model.LogconfigConfiguration body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/config/log";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.LogconfigConfiguration? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.LogconfigConfiguration>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.LogconfigConfiguration>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LogconfigConfiguration>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}