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
    /// publicUpdateInsertPartySessionStorageReserved
    ///
    /// **For Internal Use Only**
    /// Update Insert Party Session Reserved Storage User. User can only update or insert user party session storage data itself.
    /// can store generic json
    /// example json can store :
    /// ```
    /// {
    /// "key": "value",
    /// "number": 123,
    /// }
    /// ```
    /// The data will be stored on the "reserved" storage field
    /// example stored data :
    /// ```
    /// {
    /// "reserved": {
    /// "userID1": {"key": "value"},
    /// "userID2": {"key": "value"},
    /// ...
    /// }
    /// }
    /// ```
    /// </summary>
    public class PublicUpdateInsertPartySessionStorageReserved : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateInsertPartySessionStorageReservedBuilder Builder { get => new PublicUpdateInsertPartySessionStorageReservedBuilder(); }

        public class PublicUpdateInsertPartySessionStorageReservedBuilder
            : OperationBuilder<PublicUpdateInsertPartySessionStorageReservedBuilder>
        {





            internal PublicUpdateInsertPartySessionStorageReservedBuilder() { }






            public PublicUpdateInsertPartySessionStorageReserved Build(
                Dictionary<string, object> body,
                string namespace_,
                string partyId,
                string userId
            )
            {
                PublicUpdateInsertPartySessionStorageReserved op = new PublicUpdateInsertPartySessionStorageReserved(this,
                    body,
                    namespace_,
                    partyId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicUpdateInsertPartySessionStorageReserved(PublicUpdateInsertPartySessionStorageReservedBuilder builder,
            Dictionary<string, object> body,
            string namespace_,
            string partyId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateInsertPartySessionStorageReserved(
            string namespace_,
            string partyId,
            string userId,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/storage/users/{userId}/reserved";

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