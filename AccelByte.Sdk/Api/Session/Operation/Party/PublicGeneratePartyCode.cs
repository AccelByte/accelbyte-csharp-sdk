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
    /// publicGeneratePartyCode
    ///
    /// Generate a new code for the party. Only leader can generate a code.
    /// </summary>
    public class PublicGeneratePartyCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGeneratePartyCodeBuilder Builder { get => new PublicGeneratePartyCodeBuilder(); }

        public class PublicGeneratePartyCodeBuilder
            : OperationBuilder<PublicGeneratePartyCodeBuilder>
        {





            internal PublicGeneratePartyCodeBuilder() { }






            public PublicGeneratePartyCode Build(
                string namespace_,
                string partyId
            )
            {
                PublicGeneratePartyCode op = new PublicGeneratePartyCode(this,
                    namespace_,
                    partyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGeneratePartyCode(PublicGeneratePartyCodeBuilder builder,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGeneratePartyCode(
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsPartySessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsPartySessionResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}