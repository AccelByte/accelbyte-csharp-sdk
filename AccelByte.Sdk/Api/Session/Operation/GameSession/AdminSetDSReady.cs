// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminSetDSReady
    ///
    /// When the session template has ds_manual_set_ready as true. Then the DS need to calls this end point in order to notify game client if the DS is ready to accept any game client connection.
    /// </summary>
    public class AdminSetDSReady : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSetDSReadyBuilder Builder { get => new AdminSetDSReadyBuilder(); }

        public class AdminSetDSReadyBuilder
            : OperationBuilder<AdminSetDSReadyBuilder>
        {





            internal AdminSetDSReadyBuilder() { }






            public AdminSetDSReady Build(
                ApimodelsSetDSReadyRequest body,
                string namespace_,
                string sessionId
            )
            {
                AdminSetDSReady op = new AdminSetDSReady(this,
                    body,
                    namespace_,
                    sessionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminSetDSReady(AdminSetDSReadyBuilder builder,
            ApimodelsSetDSReadyRequest body,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSetDSReady(
            string namespace_,
            string sessionId,
            Model.ApimodelsSetDSReadyRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/ds";

        public override HttpMethod Method => HttpMethod.Put;

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