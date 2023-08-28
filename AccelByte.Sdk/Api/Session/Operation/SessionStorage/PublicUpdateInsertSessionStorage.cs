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
    /// publicUpdateInsertSessionStorage
    ///
    /// 
    /// Update Insert Session Storage User. user can only update or insert user session storage data itself.
    /// can store generic json
    /// example json can store :
    /// {
    /// "storage": {
    /// "storage": 1
    /// },
    /// "data": 123
    /// }
    /// </summary>
    public class PublicUpdateInsertSessionStorage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateInsertSessionStorageBuilder Builder { get => new PublicUpdateInsertSessionStorageBuilder(); }

        public class PublicUpdateInsertSessionStorageBuilder
            : OperationBuilder<PublicUpdateInsertSessionStorageBuilder>
        {





            internal PublicUpdateInsertSessionStorageBuilder() { }






            public PublicUpdateInsertSessionStorage Build(
                Dictionary<string, object> body,
                string namespace_,
                string sessionId,
                string userId
            )
            {
                PublicUpdateInsertSessionStorage op = new PublicUpdateInsertSessionStorage(this,
                    body,
                    namespace_,
                    sessionId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicUpdateInsertSessionStorage(PublicUpdateInsertSessionStorageBuilder builder,
            Dictionary<string, object> body,
            string namespace_,
            string sessionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateInsertSessionStorage(
            string namespace_,
            string sessionId,
            string userId,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}";

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