// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetServerSessionTimeout
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:CONFIG [READ]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by dedicated server
    /// to get the session timeout that will be used for the DS.
    /// DS will use this session timeout to make sure it regularly make heartbeat
    /// call to the DSMC, before the session timeout.```
    /// </summary>
    public class GetServerSessionTimeout : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetServerSessionTimeoutBuilder Builder { get => new GetServerSessionTimeoutBuilder(); }

        public class GetServerSessionTimeoutBuilder
            : OperationBuilder<GetServerSessionTimeoutBuilder>
        {





            internal GetServerSessionTimeoutBuilder() { }






            public GetServerSessionTimeout Build(
                string namespace_,
                string podName
            )
            {
                GetServerSessionTimeout op = new GetServerSessionTimeout(this,
                    namespace_,
                    podName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetServerSessionTimeout(GetServerSessionTimeoutBuilder builder,
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetServerSessionTimeout(
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/{podName}/config/sessiontimeout";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsServerDeploymentConfigSessionTimeoutResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsServerDeploymentConfigSessionTimeoutResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsServerDeploymentConfigSessionTimeoutResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}