// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// DeleteChannelHandler
    ///
    /// Deletes a matchmaking channel. Matchmaking channels is a list of
    /// pool name that is eligible for matchmaking processes. GameMode isolates each matchmaking pools.
    /// 
    /// Trying to delete non-existent channel will result deletion success
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteChannelHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteChannelHandlerBuilder Builder { get => new DeleteChannelHandlerBuilder(); }

        public class DeleteChannelHandlerBuilder
            : OperationBuilder<DeleteChannelHandlerBuilder>
        {





            internal DeleteChannelHandlerBuilder() { }






            public DeleteChannelHandler Build(
                string channel,
                string namespace_
            )
            {
                DeleteChannelHandler op = new DeleteChannelHandler(this,
                    channel,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteChannelHandler(DeleteChannelHandlerBuilder builder,
            string channel,
            string namespace_
        )
        {
            PathParams["channel"] = channel;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteChannelHandler(
            string channel,
            string namespace_
        )
        {
            PathParams["channel"] = channel;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/channels/{channel}";

        public override HttpMethod Method => HttpMethod.Delete;

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