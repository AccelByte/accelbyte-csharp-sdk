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
    /// deleteActiveQueue
    ///
    /// ```
    /// Required permission: ADMIN:DSAM:ARTIFACT:QUEUE [DELETE]
    /// 
    /// This endpoint is used to delete active queue process on a node
    /// ```
    /// </summary>
    public class DeleteActiveQueue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteActiveQueueBuilder Builder { get => new DeleteActiveQueueBuilder(); }

        public class DeleteActiveQueueBuilder
            : OperationBuilder<DeleteActiveQueueBuilder>
        {





            internal DeleteActiveQueueBuilder() { }






            public DeleteActiveQueue Build(
                string nodeIP
            )
            {
                DeleteActiveQueue op = new DeleteActiveQueue(this,
                    nodeIP
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteActiveQueue(DeleteActiveQueueBuilder builder,
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteActiveQueue(
            string nodeIP
        )
        {

            if (nodeIP is not null) QueryParams["nodeIP"] = nodeIP;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/artifacts/queues/active";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json", "text/x-log" };

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