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
    /// publicPartyInvite
    ///
    /// Invite a user to a party.
    /// </summary>
    public class PublicPartyInvite : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPartyInviteBuilder Builder { get => new PublicPartyInviteBuilder(); }

        public class PublicPartyInviteBuilder
            : OperationBuilder<PublicPartyInviteBuilder>
        {





            internal PublicPartyInviteBuilder() { }






            public PublicPartyInvite Build(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicPartyInvite op = new PublicPartyInvite(this,
                    body,
                    namespace_,
                    partyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPartyInvite(PublicPartyInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPartyInvite(
            string namespace_,
            string partyId,
            Model.ApimodelsSessionInviteRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}