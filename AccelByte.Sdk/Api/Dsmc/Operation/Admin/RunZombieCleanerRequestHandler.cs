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
    /// RunZombieCleanerRequestHandler
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [DELETE]
    /// Required scope: social
    /// 
    /// This endpoint run zombie cleaner once
    /// 
    /// use * as region name to target all regions
    /// ```
    /// </summary>
    public class RunZombieCleanerRequestHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RunZombieCleanerRequestHandlerBuilder Builder { get => new RunZombieCleanerRequestHandlerBuilder(); }

        public class RunZombieCleanerRequestHandlerBuilder
            : OperationBuilder<RunZombieCleanerRequestHandlerBuilder>
        {





            internal RunZombieCleanerRequestHandlerBuilder() { }






            public RunZombieCleanerRequestHandler Build(
                ModelsDeleteZombieRequest body,
                string namespace_
            )
            {
                RunZombieCleanerRequestHandler op = new RunZombieCleanerRequestHandler(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RunZombieCleanerRequestHandler(RunZombieCleanerRequestHandlerBuilder builder,
            ModelsDeleteZombieRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RunZombieCleanerRequestHandler(
            string namespace_,
            Model.ModelsDeleteZombieRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/workers/zombie";

        public override HttpMethod Method => HttpMethod.Post;

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