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
    /// publicUpdateInsertSessionStorageLeader
    ///
    /// 
    /// Update Insert Session Storage Leader. only Leader can update or insert user session storage data Leader.
    /// can store generic json
    /// example json can store :
    /// {
    /// "leader": {
    /// "leader": 1
    /// },
    /// "data": 123
    /// }
    /// </summary>
    public class PublicUpdateInsertSessionStorageLeader : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateInsertSessionStorageLeaderBuilder Builder { get => new PublicUpdateInsertSessionStorageLeaderBuilder(); }

        public class PublicUpdateInsertSessionStorageLeaderBuilder
            : OperationBuilder<PublicUpdateInsertSessionStorageLeaderBuilder>
        {





            internal PublicUpdateInsertSessionStorageLeaderBuilder() { }






            public PublicUpdateInsertSessionStorageLeader Build(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId
            )
            {
                PublicUpdateInsertSessionStorageLeader op = new PublicUpdateInsertSessionStorageLeader(this,
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

        private PublicUpdateInsertSessionStorageLeader(PublicUpdateInsertSessionStorageLeaderBuilder builder,
            Dictionary<string, object> body,
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

        public PublicUpdateInsertSessionStorageLeader(
            string namespace_,
            string sessionId,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/leader";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}