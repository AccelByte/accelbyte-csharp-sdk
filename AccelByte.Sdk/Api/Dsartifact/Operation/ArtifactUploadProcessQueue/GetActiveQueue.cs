// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsartifact.Operation
{
    /// <summary>
    /// getActiveQueue
    ///
    /// ```
    /// Required permission: ADMIN:DSAM:ARTIFACT:QUEUE [READ]
    /// 
    /// This endpoint is used to get an active queue process on a node
    /// ```
    /// </summary>
    public class GetActiveQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetActiveQueueBuilder Builder { get => new GetActiveQueueBuilder(); }

        public class GetActiveQueueBuilder
            : OperationBuilder<GetActiveQueueBuilder>
        {





            internal GetActiveQueueBuilder() { }






            public GetActiveQueue Build(
                string nodeIP
            )
            {
                GetActiveQueue op = new GetActiveQueue(this,
                    nodeIP
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetActiveQueue(GetActiveQueueBuilder builder,
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetActiveQueue(
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/artifacts/queues/active";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json", "text/x-log" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsQueue? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsQueue>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsQueue>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsQueue>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}