// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// WatchdogConnect
    ///
    /// Required Permission: NAMESPACE:{namespace}:ARMADA:WATCHDOG [CREATE]
    /// </summary>
    public class WatchdogConnect : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static WatchdogConnectBuilder Builder { get => new WatchdogConnectBuilder(); }

        public class WatchdogConnectBuilder
            : OperationBuilder<WatchdogConnectBuilder>
        {





            internal WatchdogConnectBuilder() { }






            public WatchdogConnect Build(
                string namespace_,
                string watchdogID
            )
            {
                WatchdogConnect op = new WatchdogConnect(this,
                    namespace_,
                    watchdogID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private WatchdogConnect(WatchdogConnectBuilder builder,
            string namespace_,
            string watchdogID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["watchdogID"] = watchdogID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public WatchdogConnect(
            string namespace_,
            string watchdogID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["watchdogID"] = watchdogID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/namespaces/{namespace}/watchdogs/{watchdogID}/connect";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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