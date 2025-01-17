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
    /// publicReadPartySessionStorage
    ///
    /// Read Party Session Storage by partyID
    /// Party Storage example:
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
    public class PublicReadPartySessionStorage : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicReadPartySessionStorageBuilder Builder { get => new PublicReadPartySessionStorageBuilder(); }

        public class PublicReadPartySessionStorageBuilder
            : OperationBuilder<PublicReadPartySessionStorageBuilder>
        {





            internal PublicReadPartySessionStorageBuilder() { }






            public PublicReadPartySessionStorage Build(
                string namespace_,
                string partyId
            )
            {
                PublicReadPartySessionStorage op = new PublicReadPartySessionStorage(this,
                    namespace_,
                    partyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicReadPartySessionStorage(PublicReadPartySessionStorageBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicReadPartySessionStorage(
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/storage";

        public override HttpMethod Method => HttpMethod.Get;

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