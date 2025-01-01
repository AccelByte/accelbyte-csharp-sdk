// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// DeleteSession
    ///
    /// Delete the session (p2p) by session ID
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSessionBuilder Builder { get => new DeleteSessionBuilder(); }

        public class DeleteSessionBuilder
            : OperationBuilder<DeleteSessionBuilder>
        {





            internal DeleteSessionBuilder() { }






            public DeleteSession Build(
                string namespace_,
                string sessionID
            )
            {
                DeleteSession op = new DeleteSession(this,
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

        private DeleteSession(DeleteSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSession(
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}