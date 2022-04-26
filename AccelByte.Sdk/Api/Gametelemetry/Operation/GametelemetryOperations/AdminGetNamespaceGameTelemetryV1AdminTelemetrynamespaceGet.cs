// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gametelemetry.Operation
{
    /// <summary>
    /// admin_get_namespace_game_telemetry_v1_admin_telemetrynamespace_get
    ///
    /// This endpoint requires valid JWT token and permission **ADMIN:ANALYTICS:TELEMETRY:{EventNamespace}** **READ**.
    /// 
    /// This endpoint retrieve namespace from kafka topic.
    /// </summary>
    public class AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder Builder = new AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder();

        public class AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder
            : OperationBuilder<AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder>
        {
            
            internal AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder() { }






            public AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet Build(
                string accessToken            )
            {
                AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet op = new AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(this,
                    accessToken
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetBuilder builder,
            string accessToken            
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }
        #endregion

        public AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(
            string accessToken
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_COOKIE);
        }

        public override string Path => "/game-telemetry/v1/admin/telemetrynamespace";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}