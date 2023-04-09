// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getPublisherConfig
    ///
    /// Get a publisher config.
    /// It will return a publisher namespace config of the given namespace and key.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:BASIC:CONFIG" , action=2 (READ)
    ///   *  Returns : config
    /// </summary>
    public class GetPublisherConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublisherConfigBuilder Builder { get => new GetPublisherConfigBuilder(); }

        public class GetPublisherConfigBuilder
            : OperationBuilder<GetPublisherConfigBuilder>
        {





            internal GetPublisherConfigBuilder() { }






            public GetPublisherConfig Build(
                string configKey,
                string namespace_
            )
            {
                GetPublisherConfig op = new GetPublisherConfig(this,
                    configKey,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetPublisherConfig(GetPublisherConfigBuilder builder,
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPublisherConfig(
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/publisher/configs/{configKey}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConfigInfo>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}