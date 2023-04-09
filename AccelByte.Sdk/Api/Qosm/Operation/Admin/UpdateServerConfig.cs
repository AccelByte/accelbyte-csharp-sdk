// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// UpdateServerConfig
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:QOS:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint updates the registered QoS service's configurable configuration'.
    /// ```
    /// </summary>
    public class UpdateServerConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateServerConfigBuilder Builder { get => new UpdateServerConfigBuilder(); }

        public class UpdateServerConfigBuilder
            : OperationBuilder<UpdateServerConfigBuilder>
        {





            internal UpdateServerConfigBuilder() { }






            public UpdateServerConfig Build(
                ModelsUpdateServerRequest body,
                string namespace_,
                string region
            )
            {
                UpdateServerConfig op = new UpdateServerConfig(this,
                    body,
                    namespace_,
                    region
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateServerConfig(UpdateServerConfigBuilder builder,
            ModelsUpdateServerRequest body,
            string namespace_,
            string region
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateServerConfig(
            string namespace_,
            string region,
            Model.ModelsUpdateServerRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/admin/namespaces/{namespace}/servers/{region}";

        public override HttpMethod Method => HttpMethod.Patch;

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