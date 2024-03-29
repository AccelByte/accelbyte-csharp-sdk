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
    /// CancelSession
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:SESSION [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by game session manager (matchmaker, lobby, etc.) to cancel a temporary dedicated server. The dedicated server cannot be canceled unless the status is CREATING
    /// </summary>
    public class CancelSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CancelSessionBuilder Builder { get => new CancelSessionBuilder(); }

        public class CancelSessionBuilder
            : OperationBuilder<CancelSessionBuilder>
        {





            internal CancelSessionBuilder() { }






            public CancelSession Build(
                string namespace_,
                string sessionID
            )
            {
                CancelSession op = new CancelSession(this,
                    namespace_,
                    sessionID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CancelSession(CancelSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CancelSession(
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/sessions/{sessionID}/cancel";

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