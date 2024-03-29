// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// UnregisterEventIDHandler
    ///
    /// Required permission `ADMIN:NAMESPACE:{namespace}:EVENT [DELETE]`and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UnregisterEventIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnregisterEventIDHandlerBuilder Builder { get => new UnregisterEventIDHandlerBuilder(); }

        public class UnregisterEventIDHandlerBuilder
            : OperationBuilder<UnregisterEventIDHandlerBuilder>
        {





            internal UnregisterEventIDHandlerBuilder() { }






            public UnregisterEventIDHandler Build(
                string eventId
            )
            {
                UnregisterEventIDHandler op = new UnregisterEventIDHandler(this,
                    eventId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UnregisterEventIDHandler(UnregisterEventIDHandlerBuilder builder,
            string eventId
        )
        {
            PathParams["eventId"] = eventId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnregisterEventIDHandler(
            string eventId
        )
        {
            PathParams["eventId"] = eventId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/registry/eventIds/{eventId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

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